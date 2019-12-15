package ids323.estudiantes.gui.modulos.vista;

import ids323.estudiantes.gui.Colors;
import ids323.estudiantes.gui.InfoPanel;
import ids323.estudiantes.gui.modulos.DisplayModule;
import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.util.Commons;
import ids323.estudiantes.util.Padding;
import ids323.estudiantes.xswing.XButton;

import javax.swing.*;
import java.awt.*;

public abstract class ModuloVista extends JPanel implements DisplayModule {
    protected final Tab associatedTab;

    protected final String title;
    protected final String subtitle;
    protected final InfoPanel infoPanel = new InfoPanel();

    private JPanel content;

    public ModuloVista(Tab tab, String title, String subtitle) {
        this.associatedTab = tab;
        this.title = title;
        this.subtitle = subtitle;
    }

    protected void construir() {
        this.setLayout(new BorderLayout());

        JPanel inner = new JPanel(new BorderLayout());
        inner.setOpaque(true);
        inner.setBackground(Colors.ACCENT_LIGHT);
        JScrollPane sp = new JScrollPane(inner);
        sp.getVerticalScrollBar().setUnitIncrement(20);
        sp.setBorder(BorderFactory.createEmptyBorder());
        sp.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        this.add(sp);

        inner.add(new Padding(15), BorderLayout.NORTH);
        inner.add(new Padding(30, Colors.BACKGROUND), BorderLayout.SOUTH);

        JPanel body = new JPanel(new BorderLayout());
        body.setOpaque(false);
        inner.add(body, BorderLayout.CENTER);

        body.add(new Padding(250, Colors.BACKGROUND), BorderLayout.WEST);
        body.add(new Padding(250, Colors.BACKGROUND), BorderLayout.EAST);

        {
            JPanel header = new JPanel(new BorderLayout());
            header.setOpaque(false);

            JPanel mainHeader = new JPanel(new BorderLayout());
            header.add(mainHeader);
            mainHeader.setOpaque(false);
            {
                //Title
                JPanel titlePanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 0,0));
                titlePanel.setOpaque(false);
                JLabel title = new JLabel(this.title);
                title.setFont(title.getFont().deriveFont(36f).deriveFont(Font.BOLD));
                title.setForeground(Colors.TEXT);
                titlePanel.add(title);
                mainHeader.add(titlePanel, BorderLayout.NORTH);
            }
            {
                //Subtitle
                JPanel subtitlePanel = new JPanel(new FlowLayout(FlowLayout.CENTER, 0,0));
                subtitlePanel.setOpaque(false);
                JLabel subtitle = new JLabel(this.subtitle);
                subtitle.setFont(subtitle.getFont().deriveFont(24f).deriveFont(Font.PLAIN));
                subtitle.setForeground(Colors.TEXT_MINOR);
                subtitlePanel.add(subtitle);
                mainHeader.add(subtitlePanel, BorderLayout.CENTER);
            }
            header.add(new Padding(15), BorderLayout.SOUTH);

            JPanel actionPanel = new JPanel(new BorderLayout());
            actionPanel.setOpaque(false);

            XButton editButton = new XButton("", new ImageIcon(Commons.getIcon("edit")));
            editButton.setBorder(new Color(0,0,0,0), 0);
            editButton.setOpaque(false);
            editButton.setBackground(new Color(255,255,255,0));
            editButton.setRolloverColor(new Color(255,255,255,64));
            editButton.setPressedColor(new Color(255,255,255,128));
            editButton.setToolTipText("Editar");

            editButton.addActionListener(e -> startEditing());

            actionPanel.add(editButton);
            actionPanel.add(new Padding(40), BorderLayout.EAST);
            actionPanel.add(new Padding(40), BorderLayout.WEST);
            actionPanel.add(new Padding(7), BorderLayout.NORTH);
            actionPanel.add(new Padding(7), BorderLayout.SOUTH);

            header.add(actionPanel, BorderLayout.EAST);
            header.add(new Padding(146,1), BorderLayout.WEST);

            body.add(header, BorderLayout.NORTH);
        }

        {
            content = new JPanel(new BorderLayout());
            body.add(content, BorderLayout.CENTER);
            content.setBackground(Colors.BACKGROUND);

            content.add(infoPanel, BorderLayout.NORTH);
        }
    }

    protected abstract void startEditing();

    protected void addSouthComponent(JComponent component) {
        content.add(component, BorderLayout.CENTER);
    }
}
