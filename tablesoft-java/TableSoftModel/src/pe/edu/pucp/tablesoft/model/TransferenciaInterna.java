package pe.edu.pucp.tablesoft.model;

/*
 * @author migue
 */
public class TransferenciaInterna extends TransferenciaTicket {
    private Categoria categoriaTo;

    public TransferenciaInterna(Categoria categoriaTo, Agente agenteResponsable) {
        super(agenteResponsable);
        this.categoriaTo = categoriaTo;
    }
    public TransferenciaInterna(){
        super();
        categoriaTo = new Categoria();
    }

    public Categoria getCategoriaTo() {
        return categoriaTo;
    }

    public void setCategoriaTo(Categoria categoriaTo) {
        this.categoriaTo = categoriaTo;
    }
    
}
