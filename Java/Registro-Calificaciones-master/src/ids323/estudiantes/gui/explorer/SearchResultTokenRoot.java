package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;

import javax.swing.*;
import java.awt.*;
import java.util.Collection;

public class SearchResultTokenRoot implements ModuleToken {

    @Override
    public String getLabel() {
        return "RESULTADOS DE LA BÚSQUEDA";
    }

    @Override
    public Image getIcon() {
        return null;
    }

    @Override
    public String getHint() {
        return null;
    }

    @Override
    public Collection<ModuleToken> getSubTokens() {
        return Ventana.projectExplorer.getSearchResults();
    }

    @Override
    public boolean isExpandable() {
        return true;
    }

    @Override
    public DisplayModule createModule(Tab tab) {
        return null;
    }

    @Override
    public void onInteract() {

    }

    @Override
    public JPopupMenu generatePopup(ProjectExplorerItem explorerItem) {
        return null;
    }
}
