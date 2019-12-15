package ids323.estudiantes.gui.modulos.edicion;

import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.modulos.edicion.logica.EntradaValor;
import ids323.estudiantes.gui.modulos.edicion.logica.ValorEdicion;
import ids323.estudiantes.util.Padding;
import ids323.estudiantes.xswing.XButton;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.Objects;

public abstract class ModuloEdicion extends JPanel implements DisplayModule {
    protected final Tab associatedTab;

    protected final String title;
    protected ArrayList<ValorEdicion<?>> valores = new ArrayList<>();

    protected ArrayList<EntradaValor> entradas = new ArrayList<>();

    protected JPanel content;

    private JPanel buttonPanel;

    public ModuloEdicion(Tab tab, String title) {
        super(new BorderLayout());
        this.associatedTab = tab;
        this.title = title;
    }

    void actualizarEntradas() {
        content.removeAll();

        ArrayList<EntradaValor> nuevasEntradas = new ArrayList<>();

        for(ValorEdicion<?> v : valores) {

            JPanel row = new JPanel(new BorderLayout());
            row.setOpaque(false);

            JLabel fieldLabel = new JLabel(v.getLabel());
            fieldLabel.setFont(fieldLabel.getFont().deriveFont(20f));

            row.add(fieldLabel, BorderLayout.NORTH);

            EntradaValor entrada = null;
            for(EntradaValor entradaAnterior : entradas) {
                if(entradaAnterior.getValorEdicion() == v) {
                    entrada = entradaAnterior;
                    break;
                }
            }
            if(entrada == null) {
                entrada = v.crearEntrada(this);
            }
            if(entrada == null) {
                System.err.println("Failed to create value input for " + v + "; handler for that class not found?");
                continue;
            }

            nuevasEntradas.add(entrada);
            JPanel fieldWrapper = new JPanel(new FlowLayout(FlowLayout.LEFT));
            fieldWrapper.setOpaque(false);
            fieldWrapper.add(entrada.getComponent());
            row.add(fieldWrapper);

            row.setMaximumSize(new Dimension(10000,50));
            content.add(row);
        }

        entradas.clear();
        entradas.addAll(nuevasEntradas);

        content.add(buttonPanel);
    }

    void construir() {
        this.setBackground(Colors.BACKGROUND);

        JPanel header = new JPanel(new BorderLayout());
        header.setBackground(Colors.ACCENT_LIGHT);
        JLabel titleLabel = new JLabel(this.title);
        titleLabel.setForeground(Colors.TEXT);
        titleLabel.setFont(titleLabel.getFont().deriveFont(36f).deriveFont(Font.BOLD));
        header.add(new Padding(15), BorderLayout.NORTH);
        header.add(new Padding(15), BorderLayout.SOUTH);
        JPanel titlePanel = new JPanel();
        titlePanel.setOpaque(false);
        titlePanel.add(titleLabel);
        header.add(titlePanel);
        this.add(header, BorderLayout.NORTH);
        JPanel contentWrapper = new JPanel(new FlowLayout(FlowLayout.LEFT));
        contentWrapper.setOpaque(false);

        content = new JPanel();
        contentWrapper.add(content);
        content.setLayout(new BoxLayout(content, BoxLayout.Y_AXIS));
        content.setOpaque(false);
        content.setBorder(
                BorderFactory.createCompoundBorder(
                        BorderFactory.createEmptyBorder(50,50,0,0),
                        BorderFactory.createCompoundBorder(
                                BorderFactory.createMatteBorder(0,3,0,0, Colors.DARK_TEXT_MINOR),
                                BorderFactory.createEmptyBorder(0,20,0,100)
                        )
                )
        );

        XButton guardar = new XButton("Guardar");

        guardar.addActionListener(e -> {
            associatedTab.save();
            TabManager.closeSelectedTab();
            endEditing();
        });

        buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        buttonPanel.setOpaque(false);

        XButton cancelar = new XButton("Cancelar");
        cancelar.addActionListener(e -> {
            TabManager.closeSelectedTab();
            endEditing();
        });

        buttonPanel.add(guardar);
        buttonPanel.add(cancelar);

        content.add(buttonPanel);

        this.add(contentWrapper, BorderLayout.CENTER);

        actualizarEntradas();
    }

    protected abstract void endEditing();

    public void onEdit() {
        associatedTab.onEdit();
    }

    @Override
    public Object getValue() {
        ArrayList<Integer> valueHashes = new ArrayList<>();
        for(EntradaValor entrada : entradas) {
            valueHashes.add(entrada.getValueCode());
        }
        return Objects.hash(valueHashes.toArray());
    }

    @Override
    public boolean canSave() {
        return true;
    }

    @Override
    public Object save() {
        boolean valid = true;
        for(EntradaValor valor : entradas) {
            String validation = valor.validateInput();
            if(validation != null) {
                valid = false;
            }
        }
        if(valid) {
            entradas.forEach(EntradaValor::setInput);
            Ventana.projectExplorer.refresh();
        }
        return getValue();
    }

    @Override
    public void focus() {

    }
}
