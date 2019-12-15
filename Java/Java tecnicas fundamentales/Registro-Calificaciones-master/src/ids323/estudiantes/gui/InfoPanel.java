package ids323.estudiantes.gui;

import javax.swing.*;
import java.awt.*;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;

public class InfoPanel extends JComponent {

    private LinkedHashMap<String, String> info = new LinkedHashMap<>();
    private Color keyColor = Colors.DARK_TEXT_MINOR;
    private Font keyFont = new Font("Tahoma", Font.BOLD, 24);
    private Color valueColor = Colors.DARK_TEXT;
    private Font valueFont = new Font("Tahoma", Font.ITALIC, 28);
    private int margin = 70;

    public InfoPanel() {
        setOpaque(false);
    }

    public String put(String key, String value) {
        return info.put(key, value);
    }

    @Override
    protected void paintComponent(Graphics g0) {
        super.paintComponent(g0);

        ((Graphics2D) g0).setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

        int x = 0;
        int oldY = margin;
        int y = 0;
        int h = 0;
        boolean left = true;

        FontMetrics keyFm = g0.getFontMetrics(keyFont);
        FontMetrics valueFm = g0.getFontMetrics(valueFont);

        Iterator<Map.Entry<String, String>> it = info.entrySet().iterator();

        while(it.hasNext()) {
            Map.Entry<String, String> entry = it.next();
            Graphics2D g = (Graphics2D) g0.create();

            int initialX = (left ? (it.hasNext() ? 0 : this.getWidth()/4) : this.getWidth()/2) + this.getWidth()/4;
            if(left) {
                y = oldY + h;
                oldY = y;
                h = 0;
            } else {
                y = oldY;
            }

            String key = entry.getKey();
            String value = entry.getValue();

            int maxWidth = (left && !it.hasNext()) ? this.getWidth() : this.getWidth()/2;

            ArrayList<String> keySegments = splitToFit(key, keyFm, maxWidth);
            ArrayList<String> valueSegments = splitToFit(value, valueFm, maxWidth);

            g.setFont(keyFont);
            g.setColor(keyColor);
            for(String segment : keySegments) {
                x = initialX;
                x -= keyFm.stringWidth(segment)/2;
                y += keyFm.getAscent();
                g.drawString(segment, x, y);
            }
            g.fillRect(x-10,y + keyFm.getDescent()/2,keyFm.stringWidth(keySegments.get(keySegments.size()-1))+20,2);

            y += 10;

            g.setFont(valueFont);
            g.setColor(valueColor);
            for(String segment : valueSegments) {
                x = initialX;
                x -= valueFm.stringWidth(segment)/2;
                y += valueFm.getAscent();
                g.drawString(segment, x, y);
            }

            y += margin;

            h = Math.max(h, y - oldY);

            left = !left;

        }

        if(!this.isPreferredSizeSet()) {
            this.setPreferredSize(new Dimension(this.getWidth(), Math.max(oldY, y)));
            revalidate();
        }
    }

    private static ArrayList<String> splitToFit(String str, FontMetrics metrics, int maxWidth) {
        ArrayList<String> segments = new ArrayList<>();
        segments.add(str);

        for(int i = 0; i < segments.size(); i++) {
            String segment;
            while(metrics.stringWidth(segment = segments.get(i)) >= maxWidth && segment.length() > 2) {
                int split = segment.length()/2;
                boolean hyphenate = false;

                String a = segment.substring(0, split);
                String b = segment.substring(split);

                if(a.contains(" ")) {
                    if(b.contains(" ")) {
                        if(a.length() - a.lastIndexOf(" ") >= b.indexOf(" ")) {
                            split += b.indexOf(" ");
                        } else {
                            split = a.lastIndexOf(" ");
                        }
                    } else {
                        split = a.lastIndexOf(" ");
                    }
                } else if(b.contains(" ")) {
                    split += b.indexOf(" ");
                } else hyphenate = true;

                segments.set(i, segment.substring(0, split).trim() + (hyphenate ? "-" : ""));
                segments.add(i+1, segment.substring(split).trim());
            }
        }

        return segments;
    }
}
