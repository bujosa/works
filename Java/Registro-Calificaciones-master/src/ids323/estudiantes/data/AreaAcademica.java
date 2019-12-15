package ids323.estudiantes.data;

/**
 * Enumeración que posee las distintas áreas académicas a las que puede pertenecer una carrera.
 *
 * En caso de que el profesor decida hacer algo con esto después.
 * */
public enum AreaAcademica {
    BASICAS("Ciencias Básicas y Ambientales"),
    SALUD("Ciencias de la Salud"),
    HUMANIDADES("Ciencias Sociales y Humanidades"),
    INGENIERIAS("Ingenierías"),
    ECONOMIA("Economía y Negocios");

    private String nombre;

    AreaAcademica(String nombre) {
        this.nombre = nombre;
    }

    public String getNombre() {
        return nombre;
    }

    public String getCodigo() {
        return name();
    }

    @Override
    public String toString() {
        return nombre;
    }
}
