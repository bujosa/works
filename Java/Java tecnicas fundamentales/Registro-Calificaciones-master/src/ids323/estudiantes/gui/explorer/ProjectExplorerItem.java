package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.explorer.base.ExplorerFlag;
import ids323.estudiantes.gui.explorer.base.ExplorerMaster;
import ids323.estudiantes.gui.explorer.base.elements.ExplorerElement;

import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.util.ArrayList;

/**
 * Created by User on 2/7/2017.
 */
public class ProjectExplorerItem extends ExplorerElement {
    private ProjectExplorerItem parent = null;

    private ModuleToken token = null;
    private int indentation = 0;

    private boolean expanded = false;

    private Image icon = null;

    private int x = 0;

    ProjectExplorerItem(ExplorerMaster master, ModuleToken token, ArrayList<ModuleToken> toOpen) {
        super(master);
        this.token = token;

        if(toOpen.contains(this.token)) {
            expand(toOpen);
        }

        this.icon = token.getIcon();
        if(this.icon != null) this.icon = this.icon.getScaledInstance(16, 16, Image.SCALE_SMOOTH);
    }

    private ProjectExplorerItem(ProjectExplorerItem parent, ModuleToken token, ArrayList<ModuleToken> toOpen) {
        super(parent.getMaster());
        this.parent = parent;

        this.token = token;
        this.indentation = parent.indentation + 1;
        this.x = indentation * master.getIndentPerLevel() + master.getInitialIndent();

        if(toOpen.contains(this.token)) {
            expand(toOpen);
        }

        this.icon = token.getIcon();
        if(this.icon != null) this.icon = this.icon.getScaledInstance(16, 16, Image.SCALE_SMOOTH);
    }

    private void expand(ArrayList<ModuleToken> toOpen) {
        for(ModuleToken subToken : token.getSubTokens()) {
            this.children.add(new ProjectExplorerItem(this, subToken, toOpen));
        }
        expanded = true;
        master.getExpandedElements().add(this.token);
        master.repaint();
    }

    private void collapse() {
        this.propagateCollapse();
        this.children.clear();
        expanded = false;
        master.repaint();
    }

    private void propagateCollapse() {
        master.getExpandedElements().remove(this.token);
        for(ExplorerElement element : children) {
            if(element instanceof ProjectExplorerItem) ((ProjectExplorerItem) element).propagateCollapse();
        }
    }

    public void render(Graphics g) {
        g.setFont(master.getFont());
        int y = master.getOffsetY();
        master.getFlatList().add(this);

        int x = (indentation * master.getIndentPerLevel()) + master.getInitialIndent();

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

        //Expand/Collapse button
        if(token.isExpandable()){
            int margin = ((master.getRowHeight() - 16) / 2);
            if(expanded) {
                g.drawImage(master.getAssetMap().get("collapse"),x,y + margin,16, 16,new Color(0,0,0,0),null);
            } else {
                g.drawImage(master.getAssetMap().get("expand"),x,y + margin,16, 16,new Color(0,0,0,0),null);
            }
        }
        x += 23;

        //File Icon
        if(this.icon != null) {
            int margin = ((master.getRowHeight() - 16) / 2);
            g.drawImage(this.icon,x + 8 - icon.getWidth(null)/2,y + margin + 8 - icon.getHeight(null)/2, null);
            x += 25;
        }

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

        g.drawString(token.getLabel(), x, master.getOffsetY() + metrics.getAscent() + ((master.getRowHeight() - metrics.getHeight())/2));
        x += metrics.stringWidth(token.getLabel());

        g2d.setComposite(oldComposite);

        if(master.getFlag(ExplorerFlag.DEBUG_WIDTH)) {
            g.setColor(Color.YELLOW);
            g.fillRect(master.getContentWidth()-2, master.getOffsetY(), 2, master.getRowHeight());
            g.setColor(Color.GREEN);
            g.fillRect(x-2, master.getOffsetY(), 2, master.getRowHeight());
        }

        master.setOffsetY(master.getOffsetY() + master.getRowHeight());
        master.setContentWidth(Math.max(master.getContentWidth(), x));
        for(ExplorerElement i : children) {
            i.render(g);
        }
    }

    private void open() {
        this.token.onInteract();
        if(token.isExpandable()) {
            if(expanded) collapse();
            else expand(new ArrayList<>());
        }
    }

    @Override
    public int getHeight() {
        return master.getRowHeight();
    }

    @Override
    public void mouseClicked(MouseEvent e) {
        if(e.getButton() == MouseEvent.BUTTON1 && !e.isControlDown() && e.getClickCount() % 2 == 0 && (e.getX() < x || e.getX() > x + master.getRowHeight())) {
            this.open();
        }
    }

    @Override
    public void mousePressed(MouseEvent e) {
        if(e.getButton() == MouseEvent.BUTTON1) {
            //x = indentation * master.getIndentPerLevel() + master.getInitialIndent();
            if(token.isExpandable() && e.getX() >= x && e.getX() <= x + 20) {
                if(expanded) collapse();
                else expand(new ArrayList<>());
            } else {
                master.setSelected(this, e);
            }
        } else if(e.getButton() == MouseEvent.BUTTON3) {
            if(!this.selected) master.setSelected(this, new MouseEvent(e.getComponent(), e.getID(), e.getWhen(), 0, e.getX(), e.getY(), e.getClickCount(), e.isPopupTrigger(), MouseEvent.BUTTON1));
            JPopupMenu menu = token.generatePopup(this);
            if(menu != null) menu.show(e.getComponent(), e.getX(), e.getY());
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
    public ModuleToken getIdentifier() {
        return token;
    }

    /*private PopupMenu generatePopup() {
        PopupMenu menu = new PopupMenu();

        String newPath;
        if(this.isDirectory) newPath = this.token;
        else if(this.parent != null) newPath = this.parent.token;
        else newPath = new File(this.token).getParent();

        List<String> selectedFiles = master.getSelectedFiles();

        {
            Menu newMenu = new Menu("New");

            menu.add(newMenu);

            // --------------------------------------------------

            Project project = ProjectManager.getAssociatedProject(new File(token));

            String projectDir = (project != null) ? project.getDirectory().getPath() + File.separator : null;

            int lastGroup = 0;

            for(FileType type : FileType.values()) {
                if(type.canCreate(projectDir, token + File.separator)) {
                    if(type.group != lastGroup) {
                        newMenu.addSeparator();
                        lastGroup = type.group;
                    }
                    newMenu.add(type.createMenuItem(newPath));
                }
            }


        }
        menu.addSeparator();


        menu.add(MenuItems.fileItem(MenuItems.FileMenuItem.COPY));
        menu.add(MenuItems.fileItem(MenuItems.FileMenuItem.PASTE));

        MenuItem deleteItem = MenuItems.fileItem(MenuItems.FileMenuItem.DELETE);
        deleteItem.setEnabled(selectedFiles.size() >= 1);
        deleteItem.addActionListener(e -> FileManager.delete(selectedFiles));
        menu.add(deleteItem);

        menu.addSeparator();
        Menu refactorMenu = new Menu("Refactor");
        menu.add(refactorMenu);

        MenuItem renameItem = MenuItems.fileItem(MenuItems.FileMenuItem.RENAME);

        refactorMenu.add(renameItem);
        refactorMenu.add(MenuItems.fileItem(MenuItems.FileMenuItem.MOVE));

        menu.addSeparator();

        MenuItem openInSystemItem = new MenuItem("Show in System Explorer", "explorer");
        openInSystemItem.addActionListener(e -> Commons.showInExplorer(this.token));

        menu.add(openInSystemItem);

        return menu;
    }*/
}
