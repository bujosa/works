package ids323.estudiantes.util;

import javax.swing.*;
import java.awt.*;

/**
 * Created by User on 2/11/2017.
 */
public class Padding extends JPanel {

    public Padding(boolean opaque) {
        this.setOpaque(opaque);
    }

    public Padding(int size) {
        this(size, size);
    }

    public Padding(int width, int height) {
        this(false);
        Dimension dim = new Dimension(width, height);
        this.setPreferredSize(dim);
        this.setMaximumSize(dim);
    }

    public Padding(int size, boolean opaque) {
        this(opaque);
        Dimension dim = new Dimension(size, size);
        this.setPreferredSize(dim);
        this.setMaximumSize(dim);
    }

    public Padding(int size, Color color) {
        this(size, true);
        this.setBackground(color);
    }
}
