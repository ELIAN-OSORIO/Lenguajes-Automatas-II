import React from 'react';
import Formulario from './components/Formulario';

export default function Home() {
  return (
    <div>   
      <Formulario/>  
      <footer className='pie-pagina'>
        <div className='grupo-1'>
            <div className="box">
              <h2>ACERCA DE</h2>
              <h2>Esta es una pequena prueba sobre mi footer en react native</h2>
            </div>
            <div className="box">
              <h2>UBICACION</h2>
              <h2>Instituto Tecnologico de Ensenada</h2>
            </div>
            <div className="box">
              <h2>CONTACTO</h2>
              <h2>al19760601@ite.edu.mx</h2>
              <h2>646 288 99 98</h2>
            </div>
        </div>
      </footer>
    </div>
  );
}
