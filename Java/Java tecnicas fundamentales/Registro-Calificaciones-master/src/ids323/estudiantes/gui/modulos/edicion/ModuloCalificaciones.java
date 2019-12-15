package ids323.estudiantes.gui.modulos.edicion;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Asignatura;
import ids323.estudiantes.data.Calificaciones;
import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.logica.EntradaValor;
import ids323.estudiantes.gui.modulos.edicion.logica.InputAdapter;
import ids323.estudiantes.gui.modulos.edicion.logica.ValorEdicion;
import ids323.estudiantes.util.DocumentAdapter;
import ids323.estudiantes.xswing.XButton;
import ids323.estudiantes.xswing.XDropdownMenu;
import ids323.estudiantes.xswing.XNumberField;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.HashMap;

public class ModuloCalificaciones extends ModuloEdicion {

    private Calificaciones calificaciones;

    @SuppressWarnings("unchecked")
    private InputAdapter gradeInputAdapter = (valor, modulo) -> new EntradaValor() {

        private JPanel panel;
        private XDropdownMenu<Object> keyField;
        private XNumberField valueField;
        private JLabel error;
        private XButton removeButton;

        private XDropdownMenu<Object> addField;

        private HashMap<Object, Integer> map = new HashMap<>();

        {
            Dimension defFieldSize = new Dimension(400, 45);
            float defFieldFontSize = 20f;

            map.putAll(((HashMap<Asignatura, Integer>) valor.getDefaultValue()));

            panel = new JPanel(new BorderLayout());
            panel.setOpaque(false);

            JPanel fieldPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
            fieldPanel.setOpaque(false);
            panel.add(fieldPanel, BorderLayout.CENTER);

            keyField = new XDropdownMenu<>(getNewSelectOptions());

            valueField = new XNumberField();

            fieldPanel.add(keyField);
            fieldPanel.add(valueField);

            error = new JLabel();

            removeButton = new XButton("X"/*, new ImageIcon(Commons.getIcon("remove").getScaledInstance(24, 24, Image.SCALE_SMOOTH))*/);
            removeButton.setPreferredSize(new Dimension(defFieldSize.height, defFieldSize.height));
            removeButton.setToolTipText("Remover asignatura de registro de calificaciones");
            removeButton.setFont(removeButton.getFont().deriveFont(16f));
            removeButton.setBackground(Colors.ACCENT_LIGHT);
            removeButton.setRolloverColor(Colors.ACCENT_DARKER);
            removeButton.setPressedColor(Colors.ACCENT_DARKEST);
            removeButton.setForeground(Colors.TEXT);
            fieldPanel.add(removeButton);

            removeButton.addActionListener(e -> {
                int result = JOptionPane.showOptionDialog(Ventana.jframe, "¿Está seguro de que quiere remover la asignatura " + keyField.getValue() + " de este reporte de calificaciones?", "Confirmación de acción", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE, new ImageIcon(Calificaciones.ICON), new String[] {"Si", "No"}, "Si");
                if(result != JOptionPane.YES_OPTION) return;

                map.remove(keyField.getValue());
                refresh();
            });

            fieldPanel.add(error);

            keyField.setForeground(Colors.INPUT_TEXT);
            keyField.setPreferredSize(defFieldSize);
            keyField.setFont(keyField.getFont().deriveFont(defFieldFontSize).deriveFont(Font.PLAIN));

            valueField.setForeground(Colors.INPUT_TEXT);
            valueField.setPreferredSize(defFieldSize);
            valueField.setFont(valueField.getFont().deriveFont(defFieldFontSize));

            error.setFont(error.getFont().deriveFont(16f));
            error.setForeground(Colors.ERROR_TEXT);

            JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
            buttonPanel.setOpaque(false);
            panel.add(buttonPanel, BorderLayout.SOUTH);

            addField = new XDropdownMenu<>(getNewAddOptions());
            addField.setPreferredSize(defFieldSize);
            addField.setFont(addField.getFont().deriveFont(defFieldFontSize*0.9f).deriveFont(Font.PLAIN));
            addField.addChoiceListener(c -> {
                if(c instanceof Asignatura) {
                    addField.setValueIndex(0);
                    map.put(c, 100);
                    refresh();
                    keyField.setValue(c);
                }
            });

            addField.setValueIndex(0);

            buttonPanel.add(addField);

            valueField.getDocument().addDocumentListener((DocumentAdapter) e -> {
                if(validateInput() == null && keyField.getValue() instanceof Asignatura) {
                    map.put(keyField.getValue(), valueField.getValue());
                }
            });

            keyField.addChoiceListener(c -> update());

            keyField.setValueIndex(0);
        }

        private void refresh() {
            keyField.setOptions(getNewSelectOptions());
            addField.setOptions(getNewAddOptions());
            update();
        }

        private void update() {
            valueField.setVisible(keyField.getValue() instanceof Asignatura);
            removeButton.setVisible(keyField.getValue() instanceof Asignatura);
            if(!(keyField.getValue() instanceof Asignatura)) valueField.setValue(0);
            else valueField.setValue(map.get(keyField.getValue()));
            validateInput();
        }

        private Object[] getNewSelectOptions() {
            ArrayList<Object> options = new ArrayList<>();
            if(map.isEmpty()) {
                options.add("No hay asignaturas seleccionadas");
            } else {
                options.add("Seleccione asignatura a calificar");
                options.addAll(map.keySet());
            }
            return options.toArray();
        }

        private Object[] getNewAddOptions() {
            ArrayList<Object> options = new ArrayList<>();
            if(map.size() == Main.registro.asignaturas.size()) {
                options.add("No existen más asignaturas");
            } else {
                options.add("+ Agregar asignatura (" + map.size() + "/" + Main.registro.asignaturas.size() + ")");
                for(Asignatura asig : Main.registro.asignaturas) {
                    if(!map.containsKey(asig)) options.add(asig);
                }
            }
            return options.toArray();
        }

        @Override
        public JComponent getComponent() {
            return panel;
        }

        @Override
        public String validateInput() {
            modulo.onEdit();
            String result = valueField.getText() == null ? "Formato inválido" : valueField.getValue() >= 0 && valueField.getValue() <= 100 ? null : "Calificación debe estar entre 0 y 100";
            error.setText(result != null ? "*" + result : null);
            return result;
        }

        @Override
        public void setInput() {
            valor.getSetter().set(map);
        }

        @Override
        public ValorEdicion<?> getValorEdicion() {
            return valor;
        }

        @Override
        public int getValueCode() {
            return map.hashCode();
        }
    };

    public ModuloCalificaciones(Tab tab, Calificaciones calificaciones) {
        super(tab, "Editando calificaciones de " + calificaciones.getEstudiante() + " para " + calificaciones.getTrimestre());
        this.calificaciones = calificaciones;

        valores.add(new ValorEdicion<>("Ciclo trimestral", calificaciones.getTrimestre(), v -> {
            for(Calificaciones calif : Main.registro.calificaciones) {
                if(calif.getEstudiante() == this.calificaciones.getEstudiante() && calif != this.calificaciones && calif.getTrimestre().equals(v)) {
                    return "Ya existe un reporte de calificaciones de este estudiante para el trimestre " + v;
                }
            }
            return null;
        }, calificaciones::setTrimestre));

        valores.add(new ValorEdicion<>("Calificaciones", calificaciones.getCalificaciones(), v -> null, v -> {calificaciones.getCalificaciones().clear(); calificaciones.getCalificaciones().putAll(v);}, gradeInputAdapter));

        construir();
    }

    @Override
    protected void endEditing() {
        TabManager.closeTab(TabManager.getTabForToken(calificaciones.getEstudiante()));
        TabManager.openTab(calificaciones.getEstudiante());
    }
}
