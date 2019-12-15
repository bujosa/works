package ids323.estudiantes.gui.modulos.vista;

import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.explorer.GradeExplorerMaster;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.util.StringUtil;

import javax.swing.*;
import java.awt.*;
import java.util.Calendar;

public class ModuloVistaEstudiante extends ModuloVista {

    private Estudiante estudiante;

    private GradeExplorerMaster gradeExplorer;

    public ModuloVistaEstudiante(Tab tab, Estudiante estudiante) {
        super(tab, estudiante.getNombre() + " " + estudiante.getApellido(), estudiante.getId() + "");
        this.estudiante = estudiante;

        infoPanel.put("CARRERA", estudiante.getCarrera().getNombre());
        infoPanel.put("CONDICIÓN", estudiante.getEstado().toString());

        infoPanel.put("FECHA DE NACIMIENTO",
        estudiante.getFechaNacimiento().get(Calendar.DAY_OF_MONTH) +
                " de " +
                "enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre".split(",")[estudiante.getFechaNacimiento().get(Calendar.MONTH)] +
                " " +
                estudiante.getFechaNacimiento().get(Calendar.YEAR));

        infoPanel.put("NACIONALIDAD", estudiante.isExtranjero() ? "Extranjero/a" : "Dominicano/a");
        infoPanel.put("ÍNDICE GENERAL", estudiante.getIndiceGeneral() >= 0 ? StringUtil.stripDecimals(estudiante.getIndiceGeneral(),2) : "-");
        infoPanel.put("HONORES", estudiante.getHonores());

        gradeExplorer = new GradeExplorerMaster(estudiante);
        gradeExplorer.setFont(new JLabel().getFont().deriveFont(20f).deriveFont(Font.PLAIN));
        gradeExplorer.refresh();

        construir();

        JPanel wrapper = new JPanel(new BorderLayout());
        wrapper.setOpaque(false);
        JPanel califHeaderPanel = new JPanel();
        califHeaderPanel.setOpaque(false);
        JLabel califLabel = new JLabel("CALIFICACIONES");
        califLabel.setFont(califLabel.getFont().deriveFont(24f));
        califLabel.setForeground(Colors.DARK_TEXT);
        califHeaderPanel.add(califLabel);
        wrapper.add(califHeaderPanel, BorderLayout.NORTH);
        wrapper.add(gradeExplorer, BorderLayout.CENTER);

        addSouthComponent(wrapper);
    }

    @Override
    protected void startEditing() {
        estudiante.setEditando(true);
        TabManager.closeTab(TabManager.getTabForToken(estudiante));
        TabManager.openTab(estudiante);
    }

    @Override
    public Object getValue() {
        return null;
    }

    @Override
    public boolean canSave() {
        return false;
    }

    @Override
    public Object save() {
        return null;
    }

    @Override
    public void focus() {

    }
}
