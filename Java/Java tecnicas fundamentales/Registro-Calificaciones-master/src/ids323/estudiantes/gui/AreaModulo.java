package ids323.estudiantes.gui;

import ids323.estudiantes.gui.modulos.Tab;
import ids323.estudiantes.gui.modulos.TabManager;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.InputEvent;
import java.awt.event.KeyEvent;

public class AreaModulo extends JPanel {

    private JPanel tabList;

    private JComponent content = null;

    {
        this.setLayout(new BorderLayout());
        this.setPreferredSize(new Dimension(500, 500));

        JPanel tabListHolder = new JPanel(new BorderLayout());

        tabListHolder.setBackground(new Color(200, 202, 205));
        tabListHolder.setPreferredSize(new Dimension(1, 35));

        this.add(tabListHolder, BorderLayout.NORTH);

        tabList = new JPanel(new FlowLayout(FlowLayout.LEFT, 0, 0));

        tabList.setBackground(new Color(200, 202, 205));
        tabList.setPreferredSize(new Dimension(1, 30));
        tabList.setBorder(BorderFactory.createMatteBorder(0, 0, 1, 0, new Color(200, 200, 200)));

        JScrollPane tabSP = new JScrollPane(Ventana.tabList);
        tabSP.setBorder(BorderFactory.createEmptyBorder());
        tabSP.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_NEVER);

        tabListHolder.add(tabSP, BorderLayout.CENTER);

        this.setContent(Ventana.welcomePane);


        KeyStroke saveKeystroke = KeyStroke.getKeyStroke(KeyEvent.VK_S, InputEvent.CTRL_MASK);

        this.getInputMap(WHEN_IN_FOCUSED_WINDOW).put(saveKeystroke, "saveKeystroke");

        this.getActionMap().put("saveKeystroke", new AbstractAction() {

            @Override
            public void actionPerformed(ActionEvent e) {
                Tab st = TabManager.getSelectedTab();
                if(st != null) st.save();
            }
        });


        KeyStroke closeKeystroke = KeyStroke.getKeyStroke(KeyEvent.VK_W, InputEvent.CTRL_MASK);

        this.getInputMap(WHEN_IN_FOCUSED_WINDOW).put(closeKeystroke, "closeKeystroke");

        this.getActionMap().put("closeKeystroke", new AbstractAction() {

            @Override
            public void actionPerformed(ActionEvent e) {
                TabManager.closeSelectedTab();
            }
        });
    }

    public void setContent(JComponent content) {
        if(this.content != null) {
            this.remove(this.content);
        }
        if(content == null) content = Ventana.welcomePane;

        this.add(content, BorderLayout.CENTER);
        this.content = content;

        this.revalidate();
        this.repaint();
    }
}
