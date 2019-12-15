package ids323.estudiantes.xswing;

import ids323.estudiantes.util.DocumentAdapter;

import javax.swing.*;
import java.awt.*;
import java.util.regex.Pattern;

public class XTextField extends JTextField {

	private int borderThickness = 1;
	
	{
		setBackground(new Color(225,225,225));
		setBorder(BorderFactory.createCompoundBorder(BorderFactory.createLineBorder(new Color(150,150,150)), BorderFactory.createEmptyBorder(0, 5, 0, 5)));
	}

	private Pattern pattern = null;
	private Color normalForeground = Color.BLACK;
	private Color errorForeground = Color.RED;
	
	public XTextField() {
		this("");
	}

    public XTextField(String text) {
        this(text, null);
    }

    public XTextField(String text, Pattern pattern) {
        super(text);
        if(pattern != null) this.pattern = pattern;
        this.getDocument().addDocumentListener((DocumentAdapter) e -> validateText());
    }

	protected void validateText() {
        String t = super.getText();
        super.setForeground(pattern == null || pattern.matcher(t).matches() ? normalForeground : errorForeground);
    }

    @Override
    public void setText(String t) {
        super.setText(t);
        validateText();
    }

    @Override
    public String getText() {
        String t = super.getText();
        return pattern == null || pattern.matcher(t).matches() ? t : null;
    }

    public void setBorder(Color bc, int thickness) {
		this.borderThickness = thickness;
		setBorder(BorderFactory.createCompoundBorder(BorderFactory.createLineBorder(bc, thickness), BorderFactory.createEmptyBorder(0, 5, 0, 5)));
	}
	
	public void setForeground(Color fg) {
	    this.normalForeground = fg;
		this.setCaretColor(fg);
		super.setForeground(fg);
	}

	public int getBorderThickness() {
		return borderThickness;
	}
}
