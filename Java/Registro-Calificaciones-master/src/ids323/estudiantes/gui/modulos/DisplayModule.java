package ids323.estudiantes.gui.modulos;

public interface DisplayModule {
    Object getValue();
    boolean canSave();
    Object save();
    void focus();
}
