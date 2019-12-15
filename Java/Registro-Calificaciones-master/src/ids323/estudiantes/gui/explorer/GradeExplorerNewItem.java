package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Calificaciones;
import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.data.Trimestre;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.explorer.base.elements.ExplorerElement;
import ids323.estudiantes.gui.modulos.TabManager;

import java.awt.*;
import java.awt.event.MouseEvent;

public class GradeExplorerNewItem extends ExplorerElement {

    private GradeExplorerMaster parent;
    private Estudiante estudiante;

    private boolean pressed = false;

    public GradeExplorerNewItem(GradeExplorerMaster parent, Estudiante estudiante) {
        super(parent);
        this.parent = parent;
        this.estudiante = estudiante;
    }

    @Override
    public void render(Graphics g) {
        master.getFlatList().add(this);

        g.setColor(pressed ? master.getColorMap().get("item.selected.background") : (this.rollover || this.selected) ? master.getColorMap().get("item.rollover.background") : master.getColorMap().get("item.background"));
        g.fillRect(0, master.getOffsetY(), master.getWidth(), this.getHeight());

        g.setColor(master.getColorMap().get("item.foreground"));
        g.setFont(master.getFont().deriveFont(Font.BOLD));

        FontMetrics fm = g.getFontMetrics();
        String label = "+ Nuevo reporte de calificaciones";

        g.drawString(label, master.getWidth()/2 - fm.stringWidth(label)/2, master.getOffsetY() + ((this.getHeight()/2) + (fm.getAscent()/2)) - 2);

        master.setOffsetY(master.getOffsetY() + getHeight());
    }

    @Override
    public ModuleToken getIdentifier() {
        return null;
    }

    @Override
    public int getHeight() {
        return master.getRowHeight();
    }

    @Override
    public void mouseClicked(MouseEvent e) {

        Trimestre trimestre = Trimestre.getTrimestreCercano();

        while(true) {
            boolean valido = true;
            for(Calificaciones calif : estudiante.getAllCalificaciones()) {
                if(calif.getTrimestre().equals(trimestre)) {
                    trimestre = trimestre.getProximo();
                    valido = false;
                    break;
                }
            }
            if(valido) break;
        }

        Calificaciones calif = new Calificaciones(trimestre, estudiante);
        Main.registro.calificaciones.add(calif);
        TabManager.openTab(calif);

        master.refresh();
    }

    @Override
    public void mousePressed(MouseEvent e) {
        pressed = true;
        master.repaint();
    }

    @Override
    public void mouseReleased(MouseEvent e) {
        pressed = false;
        master.repaint();
    }

    @Override
    public void mouseEntered(MouseEvent e) {
        master.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
    }

    @Override
    public void mouseExited(MouseEvent e) {
        master.setCursor(Cursor.getDefaultCursor());
        pressed = false;
    }
}
