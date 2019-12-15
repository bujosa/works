package ids323.estudiantes.gui.modulos.edicion.logica;

import ids323.estudiantes.gui.modulos.edicion.ModuloEdicion;

import java.util.Collection;

public class ValorEdicion<T> {
    private final String label;
    private final T defaultValue;
    private final ValidacionValor<T> validacion;
    private final SetterValor<T> setter;
    private Collection<T> possibleValues;

    private InputAdapter adapter;

    public ValorEdicion(String label, T defaultValue, ValidacionValor<T> validacion, SetterValor<T> setter) {
        this(label, defaultValue, validacion, setter, StandardInputAdapters.getAdapterForClass(defaultValue.getClass()));
    }

    public ValorEdicion(String label, T defaultValue, ValidacionValor<T> validacion, SetterValor<T> setter, InputAdapter adapter) {
        this.label = label;
        this.defaultValue = defaultValue;
        this.validacion = validacion;
        this.setter = setter;

        this.adapter = adapter;
    }

    public ValorEdicion(String label, T defaultValue, ValidacionValor<T> validacion, SetterValor<T> setter, Collection<T> possibleValues) {
        this(label, defaultValue, validacion, setter, StandardInputAdapters.customInputAdapter);
        this.possibleValues = possibleValues;
    }

    public String getLabel() {
        return label;
    }

    public T getDefaultValue() {
        return defaultValue;
    }

    public ValidacionValor<T> getValidacion() {
        return validacion;
    }

    public SetterValor<T> getSetter() {
        return setter;
    }

    public Collection<T> getPossibleValues() {
        return possibleValues;
    }

    public EntradaValor crearEntrada(ModuloEdicion modulo) {
        return adapter.crearEntrada(this, modulo);
    }
}
