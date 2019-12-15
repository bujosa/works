package ids323.estudiantes.xswing;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.regex.Pattern;

public class XNumberField extends XTextField implements KeyListener {

    private int min = Integer.MIN_VALUE;
    private int max = Integer.MAX_VALUE;

    private static final String allowedCharacters = "-+0123456789";
    private int value;

    public XNumberField() {
        this(1);
    }

    public XNumberField(int text) {
        super("" + text, Pattern.compile("[-+]?\\d+"));

        this.addKeyListener(this);
    }

    public int getValue() {
        try {
            return Integer.parseInt(getText());
        } catch(NumberFormatException x) {
            return 0;
        }
    }

    public void setValue(int value) {
        this.setText(String.valueOf(value));
    }

    @Override
    public void keyTyped(KeyEvent e) {
        if(!allowedCharacters.contains("" + e.getKeyChar())) e.consume();
    }

    @Override
    public void keyPressed(KeyEvent e) {
    }

    @Override
    public void keyReleased(KeyEvent e) {
    }
}
