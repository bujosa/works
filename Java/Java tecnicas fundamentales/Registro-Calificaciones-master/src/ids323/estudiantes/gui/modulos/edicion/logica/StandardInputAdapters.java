package ids323.estudiantes.gui.modulos.edicion.logica;

import ids323.estudiantes.data.MesTrimestre;
import ids323.estudiantes.data.Trimestre;
import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.util.DocumentAdapter;
import ids323.estudiantes.util.StringUtil;
import ids323.estudiantes.xswing.XDropdownMenu;
import ids323.estudiantes.xswing.XNumberField;
import ids323.estudiantes.xswing.XTextField;

import javax.swing.*;
import java.awt.*;
import java.util.Calendar;
import java.util.HashMap;
import java.util.Map;
import java.util.regex.Pattern;

@SuppressWarnings("unchecked")
public class StandardInputAdapters {

    public static final HashMap<Class, InputAdapter> inputAdapters = new HashMap<>();
    public static final InputAdapter customInputAdapter;

    static {
        Dimension defFieldSize = new Dimension(300, 45);
        float defFieldFontSize = 20f;

        inputAdapters.put(String.class, (valor, modulo) -> new EntradaValor() {
            XTextField field = new XTextField((String) valor.getDefaultValue());
            JPanel panel = new JPanel();
            JLabel error = new JLabel();

            {
                panel.setOpaque(false);
                panel.add(field);
                panel.add(error);

                field.setForeground(Colors.INPUT_TEXT);
                field.setPreferredSize(defFieldSize);
                field.setFont(field.getFont().deriveFont(defFieldFontSize));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);

                field.getDocument().addDocumentListener((DocumentAdapter) e -> validateInput());
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                String result = valor.getValidacion().validate(field.getText());
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                valor.getSetter().set(field.getText());
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return field.getText().hashCode();
            }
        });
        inputAdapters.put(Integer.class, (valor, modulo) -> new EntradaValor() {
            XNumberField field = new XNumberField((int) valor.getDefaultValue());
            JPanel panel = new JPanel();
            JLabel error = new JLabel();

            {
                panel.setOpaque(false);
                panel.add(field);
                panel.add(error);

                field.setForeground(Colors.INPUT_TEXT);
                field.setPreferredSize(defFieldSize);
                field.setFont(field.getFont().deriveFont(defFieldFontSize));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);

                field.getDocument().addDocumentListener((DocumentAdapter) e -> validateInput());
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                String result = field.getText() == null ? "Formato inválido" : valor.getValidacion().validate(field.getValue());
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                valor.getSetter().set(field.getValue());
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return field.getValue();
            }
        });
        inputAdapters.put(Enum.class, (valor, modulo) -> new EntradaValor() {
            XDropdownMenu<Object> field = new XDropdownMenu<>(((Enum) valor.getDefaultValue()).getDeclaringClass().getEnumConstants());
            JPanel panel = new JPanel();
            JLabel error = new JLabel();

            {
                panel.setOpaque(false);
                panel.add(field);
                panel.add(error);

                field.setValue(valor.getDefaultValue());
                field.setForeground(Colors.INPUT_TEXT);

                field.setMinimumSize(defFieldSize);
                field.setFont(field.getFont().deriveFont(defFieldFontSize*2/3));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);

                field.addChoiceListener(c -> validateInput());
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                String result = valor.getValidacion().validate(field.getValue());
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                valor.getSetter().set(field.getValue());
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return field.getValue().hashCode();
            }
        });
        inputAdapters.put(Calendar.class, (valor, modulo) -> new EntradaValor() {
            JPanel panel;
            XTextField field;
            JLabel error;

            {
                panel = new JPanel();
                panel.setOpaque(false);

                Calendar def = (Calendar) valor.getDefaultValue();

                String dom = "" + def.get(Calendar.DAY_OF_MONTH);
                String mon = "" + (def.get(Calendar.MONTH)+1);
                String year = "" + def.get(Calendar.YEAR);

                String formatted = StringUtil.repeat("0",2-dom.length()) + dom + "-" + StringUtil.repeat("0",2-mon.length()) + mon + "-" + StringUtil.repeat("0",4-year.length()) + year;

                field = new XTextField("", Pattern.compile("\\d{1,2}[-/]\\d{1,2}[-/]\\d+"));
                field.setToolTipText("Formato: dd-mm-aaaa");
                panel.add(field);
                error = new JLabel();
                panel.add(error);

                field.getDocument().addDocumentListener((DocumentAdapter) e -> validateInput());

                field.setText(formatted);

                field.setForeground(Colors.INPUT_TEXT);
                field.setPreferredSize(defFieldSize);
                field.setFont(field.getFont().deriveFont(defFieldFontSize));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            private Calendar parseDate() {
                String str = field.getText();
                if(str == null) return null;
                String[] segments = str.split("[-/]");

                int dia = Integer.parseInt(segments[0]);
                int mes = Integer.parseInt(segments[1]);
                int anio = Integer.parseInt(segments[2]);

                Calendar date = Calendar.getInstance();
                date.set(anio, mes-1, dia);
                return date;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                Calendar date = parseDate();
                String result = date == null ? "Formato inválido para fecha" : valor.getValidacion().validate(date);
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                Calendar date = parseDate();
                if(date != null) valor.getSetter().set(date);
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return field.getText().hashCode();
            }
        });

        customInputAdapter = (valor, modulo) -> new EntradaValor() {
            XDropdownMenu<Object> field = new XDropdownMenu<>(valor.getPossibleValues().toArray());
            JPanel panel = new JPanel();
            JLabel error = new JLabel();

            {
                panel.setOpaque(false);
                panel.add(field);
                panel.add(error);

                field.setValue(valor.getDefaultValue());
                field.setForeground(Colors.INPUT_TEXT);

                field.setMinimumSize(defFieldSize);
                field.setFont(field.getFont().deriveFont(defFieldFontSize*2/3));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                String result = valor.getValidacion().validate(field.getValue());
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                valor.getSetter().set(field.getValue());
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return field.getValue().hashCode();
            }
        };

        inputAdapters.put(Trimestre.class, (valor, modulo) -> new EntradaValor() {

            private JPanel panel;
            private XDropdownMenu<MesTrimestre> monthField;
            private XNumberField yearField;
            private JLabel error;

            {
                Dimension defFieldSize = new Dimension(300, 45);
                float defFieldFontSize = 20f;

                panel = new JPanel();
                panel.setOpaque(false);

                monthField = new XDropdownMenu<>(MesTrimestre.values());
                panel.add(monthField);
                yearField = new XNumberField();
                panel.add(yearField);
                error = new JLabel();
                panel.add(error);

                monthField.addChoiceListener(c -> validateInput());
                yearField.getDocument().addDocumentListener((DocumentAdapter) e -> validateInput());

                monthField.setValue(((Trimestre) valor.getDefaultValue()).getMes());
                yearField.setValue(((Trimestre) valor.getDefaultValue()).getAnio());

                monthField.setForeground(Colors.INPUT_TEXT);
                monthField.setPreferredSize(defFieldSize);
                monthField.setFont(monthField.getFont().deriveFont(defFieldFontSize).deriveFont(Font.PLAIN));

                yearField.setForeground(Colors.INPUT_TEXT);
                yearField.setPreferredSize(defFieldSize);
                yearField.setFont(yearField.getFont().deriveFont(defFieldFontSize));

                error.setFont(error.getFont().deriveFont(16f));
                error.setForeground(Colors.ERROR_TEXT);
            }

            @Override
            public JComponent getComponent() {
                return panel;
            }

            @Override
            public String validateInput() {
                modulo.onEdit();
                String result =
                        yearField.getText() == null ?
                                "Formato inválido" :
                                yearField.getValue() > 0 ?
                                        (valor.getValidacion().validate(new Trimestre(monthField.getValue(), yearField.getValue()))) :
                                        "Año inválido";
                error.setText(result != null ? "*" + result : null);
                return result;
            }

            @Override
            public void setInput() {
                valor.getSetter().set(new Trimestre(monthField.getValue(), yearField.getValue()));
            }

            @Override
            public ValorEdicion<?> getValorEdicion() {
                return valor;
            }

            @Override
            public int getValueCode() {
                return new Trimestre(monthField.getValue(), yearField.getValue()).hashCode();
            }
        });
    }

    public static InputAdapter getAdapterForClass(Class cls) {
        for(Map.Entry<Class, InputAdapter> entry : inputAdapters.entrySet()) {
            if(entry.getKey().isAssignableFrom(cls)) return entry.getValue();
        }
        return null;
    }
}
