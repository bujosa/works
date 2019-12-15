package ids323.estudiantes.gui.modulos;

import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.Ventana;

import javax.swing.*;
import java.util.ArrayList;

/**
 * Interface that allows communication between parts of the program and the tab
 * list.
 */
public class TabManager {

    public static ArrayList<Tab> openTabs = new ArrayList<>();

    private static Tab selectedTab = null;

    public static void openTab(ModuleToken path, int index) {
        openTab(path);
        selectLocation(selectedTab, index, 0);
    }

    public static void openTab(ModuleToken path, int index, int length) {
        openTab(path);
        selectLocation(selectedTab, index, length);
    }

    public static void openTab(ModuleToken token) {
        for (int i = 0; i < openTabs.size(); i++) {
            if (openTabs.get(i).token.equals(token)) {
                setSelectedTab(openTabs.get(i));
                return;
            }
        }
        Tab nt = new Tab(token);
        openTabs.add(nt);
        Ventana.tabList.addTab(nt);
        setSelectedTab(nt);
    }

    private static void selectLocation(Tab tab, int index, int length) {
    }

    public static void closeSelectedTab() {
        closeSelectedTab(false);
    }

    public static void closeSelectedTab(boolean force) {
        closeTab(getSelectedTab(), force);
    }

    public static void closeTab(Tab tab) {
        closeTab(tab, false);
    }

    public static void closeTab(Tab tab, boolean force) {
        if(tab == null) return;
        if(!force) {
            if(!tab.isSaved()) {
                int result = JOptionPane.showOptionDialog(Ventana.jframe, "Hay cambios sin guardar. ¿Desea guardarlos?", "Cambios sin guardar", JOptionPane.YES_NO_CANCEL_OPTION, JOptionPane.WARNING_MESSAGE, null, new String[] {"Guardar", "No guardar", "Cancelar"}, "Guardar");
                if(result == JOptionPane.CANCEL_OPTION) return;
                if(result == JOptionPane.YES_OPTION) tab.save();
            }
        }
        for (int i = 0; i < openTabs.size(); i++) {
            if (openTabs.get(i) == tab) {
                if (selectedTab == openTabs.get(i)) setSelectedTab(Ventana.tabList.getFallbackTab(tab));

                Ventana.tabList.removeTab(tab);
                openTabs.remove(i);

                return;
            }
        }
    }

    private static void updateMenu() {
        /*
        menu = new StyledPopupMenu();
        if(TabManager.openTabs.size() <= 0) {
            StyledMenuItem item = new StyledMenuItem("No tabs open!");
            item.setFont(item.getFont().deriveFont(Font.ITALIC));
            item.setIcon(new ImageIcon(Commons.getIcon("info").getScaledInstance(16, 16, Image.SCALE_SMOOTH)));
            menu.add(item);
            return;
        }
        for(int i = 0; i < TabManager.openTabs.size(); i++) {
            Tab tab = TabManager.openTabs.get(i);
            StyledMenuItem item = new StyledMenuItem(((!tab.isSaved()) ? "*" : "") + tab.getName());
            item.setIcon(new ImageIcon(tab.getLinkedTabItem().getIcon()));
            if(!tab.visible) {
                item.setFont(item.getFont().deriveFont(Font.BOLD));
            }
            item.addMouseListener(new MouseAdapter() {
                public void mousePressed(MouseEvent e) {
                    setSelectedTab(tab);
                }
            });
            menu.add(item);
        }*/
    }/*

    public static StyledPopupMenu getMenu() {
        updateMenu();
        return menu;
    }*/

    public static void setSelectedTab(Tab tab) {
        Ventana.tabList.selectTab(tab);
        if (selectedTab != null) {
            selectedTab = null;
        }
        if (tab != null) {
            selectedTab = tab;

            //CraftrWindow.setTitle(((linkedProject != null) ? linkedProject.getName() + " - " : "") + tab.getName());
            Ventana.editArea.setContent(tab.getModuleComponent());
            tab.onSelect();
        } else {
            //CraftrWindow.statusBar.setCaretInfo(Commons.DEFAULT_CARET_DISPLAY_TEXT);
            //CraftrWindow.statusBar.setSelectionInfo(" ");
            //Ventana.clearTitle();
            Ventana.editArea.setContent(null);
        }
    }

    public static Tab getSelectedTab() {
        return selectedTab;
    }

    public static Tab getTabForToken(ModuleToken token) {
        for(Tab tab : openTabs) {
            if(tab.token == token) return tab;
        }
        return null;
    }
}
