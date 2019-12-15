package ids323.estudiantes.data;

import ids323.estudiantes.gui.ModuleToken;
import ids323.estudiantes.gui.modulos.ModuleRankingToken;
import ids323.estudiantes.gui.modulos.ModuleTokenRoot;
import ids323.estudiantes.saveio.SaveReader;
import ids323.estudiantes.saveio.SaveWriter;

import java.io.*;
import java.util.ArrayList;
import java.util.Map;

/**
 * Objeto destinado a almacenar los datos del sistema, incluyendo los estudiantes y las asignaturas.
 * */
public class Registro {

    public static final byte VERSION_DATA = 2;

    /**
     * Lista para los estudiantes.
     * */
    public final ArrayList<Estudiante> estudiantes = new ArrayList<>();
    /**
     * Lista para las asignaturas.
     * */
    public final ArrayList<Asignatura> asignaturas = new ArrayList<>();
    /**
     * Lista para los profesores.
     * */
    public final ArrayList<Profesor> profesores = new ArrayList<>();
    /**
     * Lista para los reportes de calificaciones.
     * */
    public final ArrayList<Calificaciones> calificaciones = new ArrayList<>();
    /**
     * El fichero en el cual almacenar los datos persistentes.
     * */
    private final File file;

    /**
     * El ID del siguiente estudiante a crear.
     * */
    public int ID_ESTUDIANTE = 1100000;
    /**
     * El ID de la siguiente asignatura a crear.
     * */
    public int ID_ASIGNATURA = 0;
    /**
     * El ID del siguiente profesor a crear.
     * */
    public int ID_PROFESOR = 1100000;

    public ModuleToken rootToken;
    public ModuleToken rankingToken;

    /**
     * Construye un registro que se guarda en el fichero dado.
     *
     * @param file El fichero en el cual almacenar los datos persistentes.
     * */
    public Registro(File file) {
        this.file = file;

        rootToken = new ModuleTokenRoot();
        rankingToken = new ModuleRankingToken();
    }

    /**
     * Borra los datos en este objeto y los llena con los datos presentes en el fichero correspondiente a este registro.
     * */
    public void cargar() {
        ID_ASIGNATURA = 0;
        ID_ESTUDIANTE = 1100000;
        ID_PROFESOR = 0;
        estudiantes.clear();
        asignaturas.clear();

        if(!file.exists()) return;

        try(FileInputStream fis = new FileInputStream(file)) {
            SaveReader sr = new SaveReader(fis);

            int versionArchivo = sr.readByte();

            ID_ESTUDIANTE = sr.readInt();
            int cantEstudiantes = sr.readInt();
            for(int i = 0; i < cantEstudiantes; i++) {
                Estudiante est = new Estudiante(sr.readInt());
                est.setNombre(sr.readString());
                est.setApellido(sr.readString());
                est.setFechaNacimiento(sr.readDate());
                est.setEstado(Estado.values()[sr.readByte()]);
                est.setCarrera(Carrera.values()[sr.readByte()]);
                if(versionArchivo < 2) sr.readString();
                est.setExtranjero(sr.readBoolean());
                estudiantes.add(est);
            }

            ID_PROFESOR = sr.readInt();
            int cantProfesores = sr.readInt();
            for(int i = 0; i < cantProfesores; i++) {
                Profesor prof = new Profesor(sr.readInt());
                prof.setNombre(sr.readString());
                prof.setApellido(sr.readString());
                profesores.add(prof);
            }

            ID_ASIGNATURA = sr.readInt();
            int cantAsignaturas = sr.readInt();
            for(int i = 0; i < cantAsignaturas; i++) {
                Asignatura asig = new Asignatura(sr.readInt());
                asig.setCodigo(sr.readString());
                asig.setNombre(sr.readString());
                asig.setArea(AreaAcademica.values()[sr.readByte()]);
                asig.setCreditos(sr.readInt());

                int profId = sr.readInt();
                for(Profesor prof : profesores) {
                    if(prof.getId() == profId) {
                        asig.setProfesor(prof);
                        break;
                    }
                }
                asignaturas.add(asig);
            }

            int cantCalificaciones = sr.readInt();
            for(int i = 0; i < cantCalificaciones; i++) {
                Calificaciones calif = new Calificaciones();
                calif.setTrimestre(new Trimestre(MesTrimestre.values()[sr.readByte()], sr.readInt()));
                int idEst = sr.readInt();
                for(Estudiante est : estudiantes) {
                    if(est.getId() == idEst) {
                        calif.setEstudiante(est);
                        break;
                    }
                }
                int cantNotas = sr.readInt();
                for(int j = 0; j < cantNotas; j++) {
                    int idAsig = sr.readInt();
                    Asignatura asigKey = null;
                    for(Asignatura asig : asignaturas) {
                        if(asig.getId() == idAsig) {
                            asigKey = asig;
                            break;
                        }
                    }
                    calif.getCalificaciones().put(asigKey, sr.readInt());
                }
                calificaciones.add(calif);
            }
        } catch(EOFException x) {
            System.out.println("Corrupted save file");
        } catch(IOException x) {
            x.printStackTrace();
        }
    }

    /**
     * Escribe los datos de este registro en el fichero correspondiente.
     * */
    public void guardar() {

        if(!file.exists()) {
            try {
                if(!file.createNewFile()) return;
            } catch(IOException x) {
                x.printStackTrace();
                return;
            }
        }

        try(FileOutputStream fos = new FileOutputStream(file)) {
            SaveWriter sw = new SaveWriter(fos);

            sw.writeByte(VERSION_DATA);

            //Estudiantes
            sw.writeInt(ID_ESTUDIANTE);
            sw.writeInt(estudiantes.size());

            for(Estudiante est : estudiantes) {
                sw.writeInt(est.getId());
                sw.writeString(est.getNombre());
                sw.writeString(est.getApellido());
                sw.writeDate(est.getFechaNacimiento());
                sw.writeByte(est.getEstado().ordinal());
                sw.writeByte(est.getCarrera().ordinal());
                sw.writeBoolean(est.isExtranjero());
            }

            sw.writeInt(ID_PROFESOR);
            sw.writeInt(profesores.size());

            for(Profesor prof : profesores) {
                sw.writeInt(prof.getId());
                sw.writeString(prof.getNombre());
                sw.writeString(prof.getApellido());
            }

            sw.writeInt(ID_ASIGNATURA);
            sw.writeInt(asignaturas.size());

            for(Asignatura asig : asignaturas) {
                sw.writeInt(asig.getId());
                sw.writeString(asig.getCodigo());
                sw.writeString(asig.getNombre());
                sw.writeByte(asig.getArea().ordinal());
                sw.writeInt(asig.getCreditos());
                sw.writeInt(asig.getProfesor().getId());
            }

            sw.writeInt(calificaciones.size());
            for(Calificaciones calif : calificaciones) {
                sw.writeByte(calif.getTrimestre().getMes().ordinal());
                sw.writeInt(calif.getTrimestre().getAnio());
                sw.writeInt(calif.getEstudiante().getId());
                Map<Asignatura, Integer> notas = calif.getCalificaciones();
                sw.writeInt(notas.size());
                for(Map.Entry<Asignatura, Integer> nota : notas.entrySet()) {
                    sw.writeInt(nota.getKey().getId());
                    sw.writeInt(nota.getValue());
                }
            }
        } catch(IOException x) {
            x.printStackTrace();
        }
    }
}
