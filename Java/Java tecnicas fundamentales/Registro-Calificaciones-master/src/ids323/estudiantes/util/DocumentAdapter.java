package ids323.estudiantes.util;

import javax.swing.event.DocumentEvent;
import javax.swing.event.DocumentListener;

public interface DocumentAdapter extends DocumentListener {

    void onUpdate(DocumentEvent e);

    default void insertUpdate(DocumentEvent e) {
        onUpdate(e);
    }

    default void removeUpdate(DocumentEvent e) {
        onUpdate(e);
    }

    default void changedUpdate(DocumentEvent e) {
        onUpdate(e);
    }
}
