package ids323.estudiantes.gui.modulos.edicion.logica;

import javax.swing.*;

public interface EntradaValor {
    JComponent getComponent();
    String validateInput();
    void setInput();
    ValorEdicion<?> getValorEdicion();

    int getValueCode();
}
