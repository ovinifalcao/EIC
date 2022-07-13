import CardLouvor from '../../Components/CardLouvor/CardLouvor';
import PageHeader from '../../Components/PageHeader/PageHeader';
import CardsHeaderMinisterio from '../../Components/CardsHeaderMinisterio/CardsHeaderMinisterio';
import './Louvor.css'
import { useEffect, useState } from 'react';
import api from '../../services/api.js';
import ClipLoader from "react-spinners/ClipLoader";

export default function Louvor() {

  const [escalas, setEscala] = useState(null);
  let Dt_Today = new Date();
  Dt_Today.setDate(Dt_Today.getDate() - 1);

  useEffect(() => {
    api
      .get("/EscalasLouvor")
      .then((response) => setEscala(response.data));
  }, []);

  return (
    <div>
        <PageHeader/>
        <div id="hd_Louvor">
            <CardsHeaderMinisterio txt_Ministerio="Louvor"/>
        </div>

        <div id="dv_container_Escala">
          {
          !escalas? <ClipLoader color={"#43715D"} size={150} speedMultiplier={1}/>:
          escalas?.map((escala, i) => {
            
            Dt_Today.setDate(Dt_Today.getDate() - 1);
            let dateService = new Date(escala.servico.data)
            if(dateService > Dt_Today)
              return <CardLouvor
                infoDoCard = {escala}
                key={i}
                /> 
              return null;  
            })
          }
          
        </div>
    </div>
  );
}

