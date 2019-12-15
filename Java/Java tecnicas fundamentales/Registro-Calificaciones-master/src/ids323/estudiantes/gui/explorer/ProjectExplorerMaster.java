package ids323.estudiantes.gui.explorer;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Util;
import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;
import ids323.estudiantes.gui.explorer.base.ExplorerMaster;
import ids323.estudiantes.gui.explorer.base.elements.ExplorerSeparator;
import ids323.estudiantes.util.Commons;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.InputEvent;
import java.awt.event.KeyEvent;
import java.util.ArrayList;
import java.util.Collection;

/**
 * Created by User on 5/16/2017.
 */
public class ProjectExplorerMaster extends ExplorerMaster {
    private ModuleToken root;

    private ArrayList<ModuleToken> searchResults = new ArrayList<>();
    private SearchResultTokenRoot searchToken = new SearchResultTokenRoot();

    public ProjectExplorerMaster() {
        root = Main.registro.rootToken;

        colors.put("background",Colors.ACCENT_DARKEST);
        colors.put("item.background",Colors.ACCENT_DARKEST);
        colors.put("item.foreground",Colors.TEXT);
        colors.put("item.selected.background", Colors.ACCENT);
        colors.put("item.selected.foreground",Colors.TEXT);
        colors.put("item.rollover.background",Colors.ACCENT_DARKER);
        colors.put("item.rollover.foreground",Colors.TEXT);

        rowHeight = 25;
        indentPerLevel = 20;
        initialIndent = 5;

        selectionStyle = "LINE_LEFT";
        selectionLineThickness = 2;

        assets.put("expand", Commons.getIcon("expand").getScaledInstance(16, 16, Image.SCALE_SMOOTH));
        assets.put("collapse",Commons.getIcon("collapse").getScaledInstance(16, 16, Image.SCALE_SMOOTH));

        refresh();

        KeyStroke findKeystroke = KeyStroke.getKeyStroke(KeyEvent.VK_F, InputEvent.CTRL_MASK);

        this.getInputMap(WHEN_IN_FOCUSED_WINDOW).put(findKeystroke, "findKeystroke");

        this.getActionMap().put("findKeystroke", new AbstractAction() {

            @Override
            public void actionPerformed(ActionEvent e) {
                triggerSearch();
            }
        });
    }

    @Override
    public void refresh() {
        clearSelected();
        refresh(new ArrayList<>(this.getExpandedElements()));
    }

    private void refresh(ArrayList<ModuleToken> toOpen) {
        children.clear();
        flatList.clear();
        this.getExpandedElements().clear();

        Collection<ModuleToken> subTokens = root.getSubTokens();
        for(ModuleToken token : subTokens) {
            this.children.add(new ProjectExplorerItem(this, token, toOpen));
        }

        if(!searchResults.isEmpty()) {
            this.children.add(new ExplorerSeparator(this));
            this.children.add(new ProjectExplorerItem(this, searchToken, toOpen));
        }

        repaint();
    }

    public void triggerSearch() {
        String query = JOptionPane.showInputDialog(Ventana.jframe, "Introduzca lo que desea buscar", "Buscar", JOptionPane.QUESTION_MESSAGE);
        if(query == null) return;

        searchResults.clear();

        find(Util.normalizar(query.toLowerCase()), Main.registro.rootToken, searchResults);

        String message = "";

        if(searchResults.isEmpty()) {
            message = "No se encontraron resultados";
        } else if(searchResults.size() == 1) {
            message = "Se encontró 1 resultado";
        } else {
            message = "Se encontraron " + searchResults.size() + " resultados";
        }

        JOptionPane.showMessageDialog(Ventana.jframe, message);

        refresh();
    }

    private void find(String query, ModuleToken token, ArrayList<ModuleToken> found) {
        String searchInfo = token.getSearchInfo();
        if(searchInfo != null) {
            searchInfo = Util.normalizar(searchInfo.toLowerCase());
            if(searchInfo.contains(query)) found.add(token);
        }
        for(ModuleToken subToken : token.getSubTokens()) {
            find(query, subToken, found);
        }
    }

    public ArrayList<ModuleToken> getSearchResults() {
        return searchResults;
    }

    @Override
    protected void selectionUpdated() {
        super.selectionUpdated();
    }
}
