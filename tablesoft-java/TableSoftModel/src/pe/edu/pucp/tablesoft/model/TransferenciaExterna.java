package pe.edu.pucp.tablesoft.model;

/*
 * @author migue
 */
public class TransferenciaExterna extends TransferenciaTicket{
    private Proveedor proveedorTo;

    public TransferenciaExterna(Proveedor proveedorTo, Agente agenteResponsable) {
        super(agenteResponsable);
        this.proveedorTo = proveedorTo;
    }
    public TransferenciaExterna(){
        super();
        proveedorTo = new Proveedor();
    }

    public Proveedor getProveedorTo() {
        return proveedorTo;
    }

    public void setProveedorTo(Proveedor proveedorTo) {
        this.proveedorTo = proveedorTo;
    }
    
}
