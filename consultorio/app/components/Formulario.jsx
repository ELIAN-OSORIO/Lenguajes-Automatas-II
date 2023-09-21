'use client'
import React, {useState} from 'react'


const Formulario = () => {
    const [nombre, setNombre] = useState('')
    const [estatura, setEstatura] = useState('')
    const [peso, setPeso] = useState('')
    const [bmi, setBmi] = useState(0)
    const [error, setError] = useState(false)


    const handleFormulario = (e) =>{
        e.preventDefault()
        
        if([peso, estatura, nombre].includes('')){
            setError(true)
            return
        }

        let bmi = peso / Math.pow(estatura / 100, 2);
        setBmi(bmi);
        setError(false)
    }

  return (
    <div>
      <form className="flex flex-col space-y-4 justify-center p-3 m-[5%] border border-solid border-gray-400 rounded-md">

        {error && <div>Error Campos sin llenar</div>}
        <div className="flex flex-col w-full">
          <label htmlFor="nombre">nombre</label>
          <input
            type="text"
            id="nombre"
            className="bg-slate-300 p-2 rounded-md"
            placeholder="nombre"
            onChange={(e) => setNombre(e.target.value)}
            value={nombre}
          />
        </div>
        <div className="flex flex-col w-ful">
          <label htmlFor="estatura">estatura</label>
          <input
            type="text"
            id="estatura"
            className="bg-slate-300 p-2 rounded-md"
            placeholder="En centimetros"
            onChange={(e) => setEstatura(e.target.value)}
            value={estatura}
          />
        </div>
        <div className="flex flex-col w-ful">
          <label htmlFor="peso">peso</label>
          <input
            type="text"
            id="peso"
            className="bg-slate-300 p-2 rounded-md"
            placeholder="En Kilogramos"
            onChange={(e) => setPeso(e.target.value)}
            value={peso}
          />
        </div>
        <div className="flex flex-col w-ful">
          <input
            type="button"
            id="nombre"
            className="bg-slate-300 p-2 rounded-md cursor-pointer"
            value="Calcular"
            onClick={handleFormulario}
          />
        </div>
      </form>
      {bmi === 0 ? '' :
      <section className='text-4xl font-bold text-center p-2 bg-slate-400 m-[5%] rounded-md'>
      {bmi.toFixed(2)}
      </section>}
    </div>
  );
}

export default Formulario
