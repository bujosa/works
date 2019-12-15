package ids323.estudiantes.gui.modulos;

import ids323.estudiantes.data.Asignatura;
import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.data.Profesor;
import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.explorer.ProjectExplorerItem;
import ids323.estudiantes.util.Commons;
import ids323.estudiantes.xswing.menu.XMenuItem;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collection;

import static ids323.estudiantes.Main.registro;

public class ModuleTokenRoot implements ModuleToken {

    private Collection<ModuleToken> subTokens = Arrays.asList(new TokenModuloEstudiantes(), new TokenModuloAsignaturas(), new TokenModuloProfesores());

    @Override
    public String getLabel() {
        return "root";
    }

    @Override
    public Image getIcon() {
        return Commons.getIcon("file");
    }

    @Override
    public String getHint() {
        return "blah";
    }

    @Override
    public Collection<ModuleToken> getSubTokens() {
        return subTokens;
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

class TokenModuloEstudiantes implements ModuleToken {
    @Override
    public String getLabel() {
        return "ESTUDIANTES";
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
        return new ArrayList<>(registro.estudiantes);
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
        JPopupMenu menu = new JPopupMenu();
        {
            XMenuItem item = new XMenuItem("Nuevo Estudiante");
            item.addActionListener(e -> Estudiante.crearNuevo());
            menu.add(item);
        }
        return menu;
    }
}

class TokenModuloAsignaturas implements ModuleToken {
    @Override
    public String getLabel() {
        return "ASIGNATURAS";
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
        return new ArrayList<>(registro.asignaturas);
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
        JPopupMenu menu = new JPopupMenu();
        {
            XMenuItem item = new XMenuItem("Nueva Asignatura");
            item.addActionListener(e -> Asignatura.crearNueva());
            menu.add(item);
        }
        return menu;
    }
}

class TokenModuloProfesores implements ModuleToken {
    @Override
    public String getLabel() {
        return "PROFESORES";
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
        return new ArrayList<>(registro.profesores);
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
        JPopupMenu menu = new JPopupMenu();
        {
            XMenuItem item = new XMenuItem("Nuevo Profesor");
            item.addActionListener(e -> Profesor.crearNuevo());
            menu.add(item);
        }
        return menu;
    }
}