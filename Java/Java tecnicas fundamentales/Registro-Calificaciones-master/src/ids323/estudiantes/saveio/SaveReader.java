package ids323.estudiantes.saveio;

import java.io.EOFException;
import java.io.FileInputStream;
import java.io.IOException;
import java.util.Calendar;

/**
 * Objeto que sirve para leer información compleja de un fichero.
 * */
public class SaveReader {

    private final FileInputStream fis;

    public SaveReader(FileInputStream fis) {
        this.fis = fis;
    }

    /**
     * Lee 4 bytes representando un entero.
     * @return El entero leído.
     * */
    public int readInt() throws IOException {
        int n = 0;
        for(int i = 0; i < 4; i++) {
            n <<= 8;
            n += readByte();
        }
        return n;
    }

    /**
     * Lee 1 byte del fichero.
     * @return El byte leído.
     * */
    public int readByte() throws IOException {
        int read = fis.read();
        if(read == -1) throw new EOFException();
        return read;
    }

    /**
     * Lee una cadena del archivo con la siguiente estructura:
     *
     * * Lee los siguientes 4 bytes (1 int) representando la longitud de la cadena 'n'.
     * * Lee los siguientes 4*n bytes (n ints) representando cada caracter.
     *
     * @return La cadena leída.
     * */
    public String readString() throws IOException {
        int len = readInt();
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < len; i++) {
            sb.append((char) readInt());
        }
        return sb.toString();
    }

    /**
     * Lee una fecha del archivo con la siguiente estructura:
     *
     * * Lee 4 bytes (1 int) representando el año.
     * * Lee 1 byte representando el mes.
     * * Lee 1 byte representando el día.
     *
     * @return La fecha de calendario leída.
     * */
    public Calendar readDate() throws IOException {
        int year = readInt();
        int month = readByte();
        int day = readByte();
        Calendar date = Calendar.getInstance();
        date.set(year, month, day);
        return date;
    }

    public boolean readBoolean() throws IOException {
        return readByte() == 1;
    }

    public void close() throws IOException {
        fis.close();
    }
}
