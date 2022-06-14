import './CardsHeader.css';

export default function CardsHeader(props) {

    let dateService = new Date(props.infoDoServico.data)
    
    return (
        <div id="dv_TituloCard_Header">
            <h2 id="tx_PreTitulo_Header">{props.infoDoServico.descricao} do Dia</h2>
            <h1 id="tx_Titulo_Header">{dateService.getDate()} | {dateService.toLocaleDateString('pt-BR',  { month: 'long' })}</h1>
        </div>
    );
  }