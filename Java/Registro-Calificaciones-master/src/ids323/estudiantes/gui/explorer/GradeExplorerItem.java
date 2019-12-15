package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Calificaciones;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.explorer.base.ExplorerFlag;
import ids323.estudiantes.gui.explorer.base.elements.ExplorerElement;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.util.StringUtil;

import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;

public class GradeExplorerItem extends ExplorerElement {
    private GradeExplorerMaster parent = null;

    private Calificaciones calif;

    private int x = 0;
    private int y = 0;
    private boolean closeRollover = false;

    public GradeExplorerItem(GradeExplorerMaster parent, Calificaciones calif) {
        super(parent);
        this.parent = parent;
        this.calif = calif;
    }

    public void render(Graphics g) {
        g.setFont(master.getFont());
        int y = master.getOffsetY();
        this.y = y;
        master.getFlatList().add(this);

        int x = master.getInitialIndent();

        g.setColor((this.rollover || this.selected) ? master.getColorMap().get("item.rollover.background") : master.getColorMap().get("item.background"));
        g.fillRect(0, master.getOffsetY(), master.getWidth(), master.getRowHeight());
        if(this.selected) {
            g.setColor(master.getColorMap().get("item.selected.background"));

            switch(master.getSelectionStyle()) {
                case "FULL": {
                    g.fillRect(0, master.getOffsetY(), master.getWidth(), master.getRowHeight());
                    break;
                }
                case "LINE_LEFT": {
                    g.fillRect(0, master.getOffsetY(), master.getSelectionLineThickness(), master.getRowHeight());
                    break;
                }
                case "LINE_RIGHT": {
                    g.fillRect(master.getWidth() - master.getSelectionLineThickness(), master.getOffsetY(), master.getSelectionLineThickness(), master.getRowHeight());
                    break;
                }
                case "LINE_TOP": {
                    g.fillRect(0, master.getOffsetY(), master.getWidth(), master.getSelectionLineThickness());
                    break;
                }
                case "LINE_BOTTOM": {
                    g.fillRect(0, master.getOffsetY() + master.getRowHeight() - master.getSelectionLineThickness(), master.getWidth(), master.getSelectionLineThickness());
                    break;
                }
            }
        }

        x += 23;

        //File Icon
        /*if(this.icon != null) {
            int margin = ((master.getRowHeight() - 16) / 2);
            g.drawImage(this.icon,x + 8 - icon.getWidth(null)/2,y + margin + 8 - icon.getHeight(null)/2, null);
            x += 25;
        }*/

        //File Name

        if(this.selected) {
            g.setColor(master.getColorMap().get("item.selected.foreground"));
        } else if(this.rollover) {
            g.setColor(master.getColorMap().get("item.rollover.foreground"));
        } else {
            g.setColor(master.getColorMap().get("item.foreground"));
        }
        FontMetrics metrics = g.getFontMetrics(g.getFont());

        Graphics2D g2d = (Graphics2D) g;
        Composite oldComposite = g2d.getComposite();

        String label = calif.getTrimestre().toString();

        g.drawString(label, x, master.getOffsetY() + metrics.getAscent() + ((master.getRowHeight() - metrics.getHeight())/2));

        x = master.getWidth();

        Image closeIcon = master.getAssetMap().get("close");

        int margin = ((master.getRowHeight() - closeIcon.getHeight(null)) / 2);
        x -= margin;
        x -= closeIcon.getWidth(null);
        g2d.setComposite(AlphaComposite.getInstance(AlphaComposite.SRC_OVER, closeRollover ? 1f : 0.5f));
        g.drawImage(closeIcon, x, y + margin, null);
        x -= margin;

        g2d.setComposite(oldComposite);

        double indice = calif.getIndiceTrimestral();
        String labelIndice = indice >= 0 ? StringUtil.stripDecimals(indice,2) : "-";
        x -= metrics.stringWidth(labelIndice);
        g.drawString(labelIndice, x, master.getOffsetY() + metrics.getAscent() + ((master.getRowHeight() - metrics.getHeight())/2));

        if(master.getFlag(ExplorerFlag.DEBUG_WIDTH)) {
            g.setColor(Color.YELLOW);
            g.fillRect(master.getContentWidth()-2, master.getOffsetY(), 2, master.getRowHeight());
            g.setColor(Color.GREEN);
            g.fillRect(x-2, master.getOffsetY(), 2, master.getRowHeight());
        }

        master.setOffsetY(master.getOffsetY() + master.getRowHeight());
        master.setContentWidth(Math.max(master.getContentWidth(), master.getWidth()));
        for(ExplorerElement i : children) {
            i.render(g);
        }
    }

    public void open() {
        TabManager.openTab(calif);
    }

    @Override
    public ModuleToken getIdentifier() {
        return calif;
    }

    @Override
    public int getHeight() {
        return master.getRowHeight();
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        if(closeRollover) {
            int result = JOptionPane.showOptionDialog(Ventana.jframe, "¿Está seguro de que quiere borrar registro de calificaciones para el trimestre " + calif.getTrimestre() + "?", "Confirmación de acción", JOptionPane.YES_NO_OPTION, JOptionPane.WARNING_MESSAGE, new ImageIcon(Calificaciones.ICON), new String[] {"Si", "No"}, "Si");
            if(result != JOptionPane.YES_OPTION) return;

            Main.registro.calificaciones.remove(calif);
            TabManager.closeTab(TabManager.getTabForToken(calif));
            master.refresh();
            master.repaint();
        } else if(e.getButton() == MouseEvent.BUTTON1 && !e.isControlDown() && e.getClickCount() % 2 == 0) {
            this.open();
        }
    }

    @Override
    public void mousePressed(MouseEvent e) {
        if(e.getButton() == MouseEvent.BUTTON1) {
            //x = indentation * master.getIndentPerLevel() + master.getInitialIndent();
            master.setSelected(this, e);
        } else if(e.getButton() == MouseEvent.BUTTON3) {
            if(!this.selected) master.setSelected(this, new MouseEvent(e.getComponent(), e.getID(), e.getWhen(), 0, e.getX(), e.getY(), e.getClickCount(), e.isPopupTrigger(), MouseEvent.BUTTON1));
            //JPopupMenu menu = token.generatePopup(this);
            //if(menu != null) menu.show(e.getComponent(), e.getX(), e.getY());
        }
    }

    @Override
    public void mouseReleased(MouseEvent e) {

    }

    @Override
    public void mouseEntered(MouseEvent e) {

    }

    @Override
    public void mouseExited(MouseEvent e) {

    }

    @Override
    public void mouseMoved(MouseEvent e) {
        int margin = ((master.getRowHeight() - 32) / 2);
        closeRollover = e.getX() >= master.getWidth()-margin-32 &&
                e.getX() < master.getWidth()-margin &&
                e.getY() >= y + margin &&
                e.getY() < y + margin + 32;
    }
}
