import './CardMidias.css'
import CardsHeaders from '../CardsHeader/CardsHeader';
import CardFuncao from '../CardFuncao/CardFuncao';

export default function CardMidias(props){
    return(
        <div className="dv_Container">
            <CardsHeaders
                infoDoServico = {props.infoDoCard.servico}
            />

            <div id="dv_FormacaoContainer_Midias">
            {props.infoDoCard.formacao?.map((formacao, i) => (
                <CardFuncao
                infoFunca = {formacao}
                key={i}
                />
            ))}
            </div>

        </div>
    );
}