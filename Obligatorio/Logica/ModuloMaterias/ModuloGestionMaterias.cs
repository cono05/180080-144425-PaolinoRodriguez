using System;
using Dominio;
using Persistencia;
using Excepciones;
using System.Collections.Generic;

namespace Logica
{
    public class ModuloGestionMaterias: IModulo
    {
        private IRepositorio repositorio;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //private static ModuloGestionMaterias instancia;
        public ModuloGestionMaterias(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        //public static ModuloGestionMaterias ObtenerInstancia(ref RepositorioRam repositorio)
        //{
        //    if (instancia == null)
        //    {
        //        instancia = new ModuloGestionMaterias(ref repositorio);
        //    }
        //    return instancia;
        //}

        public void Alta(object obj)
        {
            ValidarAltaMateria((Materia)obj);
            repositorio.AgregarMateria((Materia)obj);
        }

        public void Baja(object obj)
        {
            ValidarBajaMateria((Materia)obj);
            EliminarMateriaEncadaAlumnoInscripto((Materia)obj);
            repositorio.EliminarMateria((Materia)obj);
        }

        public void ModificarMateria(Materia materia, string nuevoNombre)
        {
            // Por ahora solo modificamos nombre
            //ValidarBajaMateria(materia);
            //string nuevoNombre = datos;
            ValidarModificacionNombreMateria(materia, nuevoNombre);
            materia.Nombre = nuevoNombre;
        }

        public bool ExisteMateriaConMismoNombre(Materia materia)
        {
            bool retorno = false;
            foreach (Materia mat in repositorio.ObtenerMaterias())
            {
                if (mat.Nombre.Equals(materia.Nombre))
                    return true;
            }
            return retorno;
        }

        public ICollection<Materia> ObtenerMaterias()
        {
            return repositorio.ObtenerMaterias();
        }

        public bool EsMateriaSinNombre(Materia materia)
        {
            return string.IsNullOrEmpty(materia.Nombre);
        }

        public bool ExisteMateriaConMismoCodigo(Materia materia)
        {
            bool retorno = false;
            foreach (Materia m in repositorio.ObtenerMaterias())
            {                
                if (m.Codigo.Equals(materia.Codigo))
                    return true;
            }
            return retorno;
        }

        public void AgregarAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            ValidarInscripcionDeAlumnoEnMateria(materia, alumno);
            repositorio.AgregarAlumnoEnMateria(materia, alumno);
        }

        public void ValidarAltaMateria(Materia materia)
        {
            if (ExisteMateriaConMismoNombre(materia))
                throw new ExcepcionExisteMateriaConMismoNombre();
            if (EsMateriaSinNombre(materia))
                throw new ExcepcionMateriaSinNombre();
            if (ExisteMateriaConMismoCodigo(materia))
                throw new ExcepcionMateriaCodigoRepetido();
        }

        public bool EstaInscriptoEnLaMateria(Materia materia, Alumno alumno)
        {
            foreach (Alumno alumnoIterativo in materia.Alumnos)
            {
                if (TienenMismoNumeroEstudiante(alumnoIterativo, alumno))
                    return true;
            }
            return false;
        }

        public bool TienenMismoNumeroEstudiante(Alumno alumno, Alumno alumno2)
        {
            return alumno.NumeroDeEstudiante == alumno2.NumeroDeEstudiante;
        }

        private void ValidarBajaMateria(Materia materia)
        {
            if (!ExisteMateriaConMismoCodigo(materia))
                throw new ExcepcionNoExisteMateriaConEseCodigo();
        }

        public void EliminarAlumnoDeUnaMateria(Materia materia, Alumno alumno)
        {
            materia.Alumnos.Remove(alumno);
            alumno.MateriasInscripto.Remove(materia);
        }

        public void EliminarMateriaEncadaAlumnoInscripto(Materia materia)
        {
            foreach (Alumno a in repositorio.ObtenerAlumnos())
            {
                if (EstaInscriptoEnLaMateria(materia, a))
                {
                    a.MateriasInscripto.Remove(materia);
                }
            }
        }

        public bool HayMateriasRegistradas()
        {
            return ObtenerMaterias().Count > 0;
        }

        public void ValidarInscripcionDeAlumnoEnMateria(Materia materia, Alumno alumno)
        {
            if (EstaInscriptoEnLaMateria(materia, alumno))
                throw new ExcepcionAlumnoYaCursaLaMateria();
        }

        public ICollection<Alumno> ObtenerAlumnos()
        {
            return repositorio.ObtenerAlumnos();
        }

        public ICollection<Alumno> ObtenerAlumnosInscriptosEnMateria(Materia materia)
        {
            return materia.Alumnos;
        }

        public void AsignarDocenteAMateria(Materia materia, Docente docente)
        {
            ValidarAsignacionDeDocenteAMateria(materia, docente);
            materia.Docentes.Add(docente);
            docente.MateriasQueDicta.Add(materia);
        }

        public bool EsDocenteDeLaMateria(Materia materia, Docente docente)
        {
            return materia.Docentes.Contains(docente);
        }

        public void ValidarAsignacionDeDocenteAMateria(Materia materia, Docente docente)
        {
            if (EsDocenteDeLaMateria(materia, docente))
            {
                throw new ExcepcionDocenteYaDictaEstaMateria();
            }
        }

        public void ValidarModificacionNombreMateria(Materia materia, string nombre)
        {
            foreach (Materia m in ObtenerMaterias())
            {
                if (!materia.Equals(m) && m.Nombre.Equals(nombre))
                    throw new ExcepcionExisteMateriaConMismoNombre();
            }
        }

        public ICollection<Docente> ObtenerDocentesDeUnaMateria(Materia materia)
        {
            return repositorio.ObtenerDocentesDeLaMateria(materia);
        }
    }
}