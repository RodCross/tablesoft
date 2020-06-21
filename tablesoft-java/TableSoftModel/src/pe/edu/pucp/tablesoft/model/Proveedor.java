package pe.edu.pucp.tablesoft.model;

public class Proveedor {
    private int proveedorId;
    private String ruc;
    private String razonSocial;
    private String direccion;
    private String telefono;
    private String email;
    private Ciudad ciudad;
    private Boolean activo;

    public Proveedor() {   
        this.ciudad = new Ciudad();
    }

    public Proveedor(String ruc, String razonSocial, String direccion, String telefono, String email, Ciudad ciudad) {
        this.ruc = ruc;
        this.razonSocial = razonSocial;
        this.direccion = direccion;
        this.telefono = telefono;
        this.email = email;
        this.ciudad = ciudad;
    }

    public Ciudad getCiudad() {
        return ciudad;
    }

    public void setCiudad(Ciudad ciudad) {
        this.ciudad = ciudad;
    }
    

    public Boolean getActivo() {
        return activo;
    }

    public void setActivo(Boolean activo) {
        this.activo = activo;
    }

    public int getProveedorId() {
        return proveedorId;
    }

    public void setProveedorId(int proveedorId) {
        this.proveedorId = proveedorId;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public String getTelefono() {
        return telefono;
    }

    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    
    public String mostrarDatos() {
        return getProveedorId() + " - " + ruc + " - " + razonSocial;
    }
}