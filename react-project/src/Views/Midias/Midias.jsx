import PageHeader from '../../Components/PageHeader/PageHeader';
import CardMidias from '../../Components/CardMidias/CardMidias';
import CardsHeaderMinisterio from '../../Components/CardsHeaderMinisterio/CardsHeaderMinisterio';
import './Midias.css'
import { useEffect, useState } from 'react';
import api from '../../services/api.js';
import ClipLoader from "react-spinners/ClipLoader";

export default function Midias(){

    const [escalas, setEscala] = useState(null);

    let Dt_Today = new Date();
    Dt_Today.setDate(Dt_Today.getDate() - 1);

    useEffect(() => {
      api
        .get("/EscalasMidias", { params: { DataCorte: Dt_Today.toISOString().slice(0, 10) }})
        .then((response) => setEscala(response.data));
    }, []);
  
    return (
        <div>
            
            <PageHeader/>
            <div id="hd_Midias">
                <CardsHeaderMinisterio txt_Ministerio="Mídias"/>
            </div>

            <div id="dv_container_Escala">
            {
            !escalas? <ClipLoader color={"#43715D"} size={150} speedMultiplier={1}/>:
            escalas?.map((escala, i) => {

                let dateService = new Date(escala.servico.data)
                if(dateService > Dt_Today)
                return <CardMidias
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