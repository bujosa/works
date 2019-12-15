package ids323.estudiantes.gui;

import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;

import javax.swing.*;
import java.awt.*;
import java.util.Collection;

public interface ModuleToken {
    String getLabel();
    Image getIcon();
    String getHint();
    Collection<ModuleToken> getSubTokens();
    boolean isExpandable();
    DisplayModule createModule(Tab tab);

    void onInteract();

    JPopupMenu generatePopup(ProjectExplorerItem explorerItem);

    default String getSearchInfo() {
        return null;
    }
}
