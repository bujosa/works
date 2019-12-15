package ids323.estudiantes.util;

import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

public class Commons {

    public static boolean isSpecialCharacter(char ch) {
        return "\b\r\n\t\f\u007F\u001B".contains("" + ch);
    }

    public static void showInExplorer(String path) {
        try {
            if(System.getProperty("os.name").startsWith("Windows")) {
                Runtime.getRuntime().exec("Explorer.exe /select," + path);
            } else if(Desktop.isDesktopSupported()) {
                Desktop desktop = Desktop.getDesktop();
                desktop.open(new File(path).getParentFile());
            } else {
                System.err.println("Couldn't open file '" + path + "': Desktop is not supported");
            }
        } catch (IOException x) {
            x.printStackTrace();
        }
    }

    private static String getIconPath(String name) {
        return "/assets/icons/" + name + ".png";
    }

    public static BufferedImage getIcon(String name) {
        return ImageManager.load(getIconPath(name));
    }
}
