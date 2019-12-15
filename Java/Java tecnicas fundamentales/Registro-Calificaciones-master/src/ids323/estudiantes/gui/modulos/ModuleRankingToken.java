package ids323.estudiantes.gui.modulos;

import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.util.Commons;

import javax.swing.*;
import java.awt.*;
import java.util.Collection;

public class ModuleRankingToken implements ModuleToken {

    public static final Image ICON = Commons.getIcon("calificaciones");

    @Override
    public String getLabel() {
        return "Ranking";
    }

    @Override
    public Image getIcon() {
        return ICON;
    }

    @Override
    public String getHint() {
        return "Ranking de índice académico";
    }

    @Override
    public Collection<ModuleToken> getSubTokens() {
        return null;
    }

    @Override
    public boolean isExpandable() {
        return false;
    }

    @Override
    public DisplayModule createModule(Tab tab) {
        return new ModuleRanking();
    }

    @Override
    public void onInteract() {

    }

    @Override
    public JPopupMenu generatePopup(ProjectExplorerItem explorerItem) {
        return null;
    }
}
