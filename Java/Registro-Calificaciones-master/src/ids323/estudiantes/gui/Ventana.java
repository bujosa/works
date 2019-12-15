package ids323.estudiantes.gui;

import ids323.estudiantes.Main;
import ids323.estudiantes.data.Asignatura;
import ids323.estudiantes.data.Estudiante;
import ids323.estudiantes.data.Profesor;
import ids323.estudiantes.gui.explorer.ProjectExplorerMaster;
import ids323.estudiantes.gui.modulos.TabManager;
import ids323.estudiantes.gui.tablist.TabListMaster;
import ids323.estudiantes.util.Commons;
import ids323.estudiantes.util.Padding;
import ids323.estudiantes.xswing.XButton;

import javax.swing.*;
import java.awt.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class Ventana {

    public static JFrame jframe;
    public static final TabListMaster tabList = new TabListMaster();
    public static JPanel welcomePane = new JPanel();
    public static ProjectExplorerMaster projectExplorer = new ProjectExplorerMaster();
    public static AreaModulo editArea = new AreaModulo();

    public Ventana() {
        jframe = new JFrame("Registro de Calificaciones");
        jframe.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);

        JPanel contentPane = new JPanel(new BorderLayout());
        contentPane.setPreferredSize(new Dimension(700,500));
        jframe.setContentPane(contentPane);

        JPanel sidebar = new JPanel(new BorderLayout());
        sidebar.add(projectExplorer);
        sidebar.setPreferredSize(new Dimension(300,1));
        contentPane.add(sidebar, BorderLayout.WEST);

        JPanel sidebarHeader = new JPanel(new BorderLayout());
        sidebarHeader.add(new Padding(15), BorderLayout.WEST);
        JLabel sidebarLabel = new JLabel("REGISTRO");
        sidebarHeader.add(sidebarLabel);
        sidebarLabel.setForeground(Colors.TEXT);
        sidebarHeader.setPreferredSize(new Dimension(1, 35));
        sidebarHeader.setBackground(Colors.ACCENT_DARKER);
        sidebar.add(sidebarHeader, BorderLayout.NORTH);

        contentPane.add(editArea, BorderLayout.CENTER);

        JPanel toolbar = new JPanel(new FlowLayout(FlowLayout.LEFT));
        toolbar.setBackground(Colors.ACCENT_DARKER.brighter());
        contentPane.add(toolbar, BorderLayout.NORTH);

        {
            XButton button = new XButton("", new ImageIcon(Estudiante.ICON_NUEVO.getScaledInstance(26, 26, Image.SCALE_SMOOTH)));
            button.setPreferredSize(new Dimension(32, 32));
            button.setBackground(Colors.ACCENT_DARKER);
            button.setRolloverColor(Colors.ACCENT_DARKEST);
            button.setPressedColor(Colors.ACCENT_LIGHT);
            button.setBorder(Colors.ACCENT_DARKEST, 1);
            button.addActionListener(e -> Estudiante.crearNuevo());
            button.setToolTipText("Nuevo Estudiante");
            toolbar.add(button);
        }
        {
            XButton button = new XButton("", new ImageIcon(Asignatura.ICON_NUEVO.getScaledInstance(26, 26, Image.SCALE_SMOOTH)));
            button.setPreferredSize(new Dimension(32, 32));
            button.setBackground(Colors.ACCENT_DARKER);
            button.setRolloverColor(Colors.ACCENT_DARKEST);
            button.setPressedColor(Colors.ACCENT_LIGHT);
            button.setBorder(Colors.ACCENT_DARKEST, 1);
            button.addActionListener(e -> Asignatura.crearNueva());
            button.setToolTipText("Nueva Asignatura");
            toolbar.add(button);
        }
        {
            XButton button = new XButton("", new ImageIcon(Profesor.ICON_NUEVO.getScaledInstance(26, 26, Image.SCALE_SMOOTH)));
            button.setPreferredSize(new Dimension(32, 32));
            button.setBackground(Colors.ACCENT_DARKER);
            button.setRolloverColor(Colors.ACCENT_DARKEST);
            button.setPressedColor(Colors.ACCENT_LIGHT);
            button.setBorder(Colors.ACCENT_DARKEST, 1);
            button.addActionListener(e -> Profesor.crearNuevo());
            button.setToolTipText("Nuevo Profesor");
            toolbar.add(button);
        }
        {
            XButton button = new XButton("", new ImageIcon(Commons.getIcon("buscar").getScaledInstance(26, 26, Image.SCALE_SMOOTH)));
            button.setPreferredSize(new Dimension(32, 32));
            button.setBackground(Colors.ACCENT_DARKER);
            button.setRolloverColor(Colors.ACCENT_DARKEST);
            button.setPressedColor(Colors.ACCENT_LIGHT);
            button.setBorder(Colors.ACCENT_DARKEST, 1);
            button.addActionListener(e -> projectExplorer.triggerSearch());
            button.setToolTipText("Buscar");
            toolbar.add(button);
        }

        {
            XButton button = new XButton("", new ImageIcon(Commons.getIcon("calificaciones").getScaledInstance(26, 26, Image.SCALE_SMOOTH)));
            button.setPreferredSize(new Dimension(32, 32));
            button.setBackground(Colors.ACCENT_DARKER);
            button.setRolloverColor(Colors.ACCENT_DARKEST);
            button.setPressedColor(Colors.ACCENT_LIGHT);
            button.setBorder(Colors.ACCENT_DARKEST, 1);
            button.addActionListener(e -> TabManager.openTab(Main.registro.rankingToken));
            button.setToolTipText("Generar Ranking");
            toolbar.add(button);
        }


        welcomePane.setBackground(Colors.BACKGROUND);

        jframe.setExtendedState(JFrame.MAXIMIZED_BOTH);

        jframe.pack();
        jframe.setVisible(true);

        jframe.addWindowListener(new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                terminar();
            }
        });
    }

    public static boolean isVisible() {
        return jframe.isVisible();
    }

    private void terminar() {
        Main.registro.guardar();
        System.exit(0);
    }
}
