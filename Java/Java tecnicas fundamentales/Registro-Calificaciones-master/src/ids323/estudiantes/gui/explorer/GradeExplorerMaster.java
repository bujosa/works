package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Calificaciones;
import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.explorer.base.ExplorerMaster;
import ids323.estudiantes.util.Commons;

import java.awt.*;
import java.util.ArrayList;

public class GradeExplorerMaster extends ExplorerMaster {

    Estudiante estudiante;

    public GradeExplorerMaster(Estudiante estudiante) {
        this.estudiante = estudiante;

        colors.put("background", Colors.ACCENT_DARKEST);
        colors.put("item.background",Colors.ACCENT_DARKEST);
        colors.put("item.foreground",Colors.TEXT);
        colors.put("item.selected.background", Colors.ACCENT);
        colors.put("item.selected.foreground",Colors.TEXT);
        colors.put("item.rollover.background",Colors.ACCENT_DARKER);
        colors.put("item.rollover.foreground",Colors.TEXT);

        rowHeight = 50;
        indentPerLevel = 20;
        initialIndent = 5;

        selectionStyle = "LINE_LEFT";
        selectionLineThickness = 4;

        assets.put("expand", Commons.getIcon("expand").getScaledInstance(16, 16, Image.SCALE_SMOOTH));
        assets.put("collapse",Commons.getIcon("collapse").getScaledInstance(16, 16, Image.SCALE_SMOOTH));
        assets.put("close",Commons.getIcon("remove").getScaledInstance(24, 24, Image.SCALE_SMOOTH));

        refresh();
    }

    @Override
    public void refresh() {
        clearSelected();
        refresh(new ArrayList<>());
    }

    private void refresh(ArrayList<ModuleToken> toOpen) {
        children.clear();
        flatList.clear();

        for(Calificaciones calif : Main.registro.calificaciones) {
            if(calif.getEstudiante() == estudiante) {
                this.children.add(new GradeExplorerItem(this, calif));
            }
        }

        this.children.add(new GradeExplorerNewItem(this, estudiante));

        repaint();
    }
}
