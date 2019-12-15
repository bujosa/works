package ids323.estudiantes.data;

import static ids323.estudiantes.data.AreaAcademica.*;

/**
 * Enumeración que posee las distintas carreras ofrecidas en el INTEC.
 * */
public enum Carrera {
    AGN(ECONOMIA,       "Administración y Gestión de Negocios"),
    CAE(ECONOMIA,       "Contabilidad y Auditoría Empresarial"),
    ECO(ECONOMIA,       "Economía"),
    LIC(ECONOMIA,       "Licenciatura en Ingeniería Comercial"),
    MNE(ECONOMIA,       "Mercadeo y Negocios Electrónicos"),
    LNI(ECONOMIA,       "Negocios Internacionales"),
    CSE(HUMANIDADES,    "Licenciatura en Ciencias Sociales con Orientación en Educación Secundaria"),
    LCC(HUMANIDADES,    "Licenciatura en Cine y Comunicación Audiovisual"),
    LMC(HUMANIDADES,    "Licenciatura en Medios Digitales y Comunicación Social"),
    PSI(HUMANIDADES,    "Licenciatura en Psicología"),
    MED(SALUD,          "Doctor en Medicina"),
    ODO(SALUD,          "Doctor en Odontología"),
    LBE(BASICAS,        "Licenciatura en Biología con Orientación en Educación Secundaria"),
    LBT(BASICAS,        "Licenciatura en Biotecnología"),
    LFE(BASICAS,        "Licenciatura en Física con Orientación en Educación Secundaria"),
    LME(BASICAS,        "Licenciatura en Matemática con Orientación en Educación Secundaria"),
    MAT(BASICAS,        "Licenciatura en Matemáticas con concentración en Estadísticas y Ciencias Actuariales"),
    LQE(BASICAS,        "Licenciatura en Química con Orientación en Educación Secundaria"),
    CII(INGENIERIAS,    "Ciencias de la Ingeniería"),
    CMI(INGENIERIAS,    "Ciencias de los Materiales e Ingeniería"),
    DIN(INGENIERIAS,    "Diseño Industrial"),
    AMB(INGENIERIAS,    "Ingeniería Ambiental"),
    BIO(INGENIERIAS,    "Ingeniería Biológica"),
    CIV(INGENIERIAS,    "Ingeniería Civil"),
    ENE(INGENIERIAS,    "Ingeniería de Energía"),
    MIN(INGENIERIAS,    "Ingeniería de Minas"),
    SIS(INGENIERIAS,    "Ingeniería de Sistemas"),
    IDS(INGENIERIAS,    "Ingeniería de Software"),
    ELE(INGENIERIAS,    "Ingeniería Eléctrica"),
    INL(INGENIERIAS,    "Ingeniería Electrónica y de Comunicaciones"),
    CIB(INGENIERIAS,    "Ingeniería en Ciberseguridad"),
    IND(INGENIERIAS,    "Ingeniería Industrial"),
    MEC(INGENIERIAS,    "Ingeniería Mecánica"),
    IMC(INGENIERIAS,    "Ingeniería Mecatrónica"),
    NUC(INGENIERIAS,    "Ingeniería Nuclear");

    /**
     * El nombre legible de la carrera
     * */
    private String nombre;
    /**
     * El área académica a la que pertenece la carrera. En caso de que el profesor decida hacer algo con esto después.
     * */
    private AreaAcademica area;

    /**
     * Crea un objeto Carrera.
     *
     * @param area El área académica a la que pertenece la carrera
     * @param nombre El nombre legible de la carrera
     * */
    Carrera(AreaAcademica area, String nombre) {
        this.nombre = nombre;
        this.area = area;
    }

    /**
     * Obtiene el nombre legible de la carrera.
     * */
    public String getNombre() {
        return nombre;
    }

    /**
     * Obtiene el código de 3 letras de la carrera.
     * */
    public String getCodigo() {
        return name();
    }

    /***
     * Obtiene el área académica de la carrera.
     */
    public AreaAcademica getArea() {
        return area;
    }

    @Override
    public String toString() {
        return name() + " - " + nombre;
    }
}
