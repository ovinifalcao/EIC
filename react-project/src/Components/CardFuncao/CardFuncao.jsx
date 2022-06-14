import './CardFuncao.css'


export default function CardFuncao(props) {
    return (
        <div id="dv_Container_Funcao">
            <img id="img_Funcao" src={"https://equipeicfcapao.com.br/imgs/fn_"+props.infoFunca.funcao.id+".png"}/>
            <h3 id="tx_Ministro_Funcao">{props.infoFunca.ministro.nome}</h3>
            <small>{props.infoFunca.funcao.descricao}</small>
        </div>
    ); 
  }