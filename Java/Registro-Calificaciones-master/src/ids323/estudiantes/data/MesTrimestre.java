package ids323.estudiantes.data;

public enum MesTrimestre {
    FEBRERO("Febrero-Abril %d", "Febrero %d"), //1
    MAYO("Mayo-Julio %d", "Mayo %d"), //4
    AGOSTO("Agosto-Octubre %d", "Agosto %d"), //7
    NOVIEMBRE("Noviembre %d-Enero %d", "Noviembre %d"); //10

    String formato;
    String corto;

    MesTrimestre(String formato, String corto) {
        this.formato = formato;
        this.corto = corto;
    }

    public String getFormato() {
        return formato;
    }

    public String getCorto() {
        return corto;
    }

    public String getNombre() {
        return corto.substring(0, corto.indexOf(' '));
    }

    @Override
    public String toString() {
        return formato.replace("%d","").replace(" -","-").trim();
    }
}
