package ids323.estudiantes.data;

import java.util.Calendar;
import java.util.Objects;

public class Trimestre {
    private MesTrimestre mes;
    private int anio;

    public Trimestre(MesTrimestre mes, int anio) {
        this.mes = mes;
        this.anio = anio;
    }

    public static Trimestre getTrimestreCercano() {
        Calendar now = Calendar.getInstance();

        int anio = now.get(Calendar.YEAR);
        int mes = now.get(Calendar.MONTH);

        while((mes-1) % 3 != 0) {
            mes = Util.mod(mes-1,12);
        }
        if(mes > now.get(Calendar.MONTH)) anio--;
        Trimestre trimestre = new Trimestre(MesTrimestre.values()[(mes-1)/3], anio);
        return trimestre;
    }

    public Trimestre getProximo() {
        int index = this.mes.ordinal()+1;
        int anio = this.anio;
        if(index >= MesTrimestre.values().length) {
            anio++;
            index = 0;
        }
        return new Trimestre(MesTrimestre.values()[index], anio);
    }

    @Override
    public String toString() {
        return mes.formato.replaceFirst("%d", "" + anio).replaceFirst("%d", "" + (anio+1));
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Trimestre trimestre = (Trimestre) o;
        return anio == trimestre.anio &&
                mes == trimestre.mes;
    }

    @Override
    public int hashCode() {
        return Objects.hash(mes, anio);
    }

    public MesTrimestre getMes() {
        return mes;
    }

    public int getAnio() {
        return anio;
    }
}
