import './CardLouvor.css';
import CardFuncao from '../CardFuncao/CardFuncao';
import CardStreaming from '../CardStreaming/CardStreaming';
import CardsHeaders from '../CardsHeader/CardsHeader';

export default function CardLouvor(props) {

  let dateService = new Date(props.infoDoCard.servico.data).getDay()
  console.log(dateService)

    return (
      <div className="dv_Container"
      style = {dateService === 5 ? {backgroundColor: 'rgba(190, 208, 21, 0.1)'} : {backgroundColor: 'rgba(255, 255, 255, 0.4)'} }
      >

        <CardsHeaders
          infoDoServico = {props.infoDoCard.servico}
        />

        <div id="dv_SpotifyEmbedded_Louvor">
            <iframe src={"https://open.spotify.com/embed/playlist/"+props.infoDoCard.playlist[0].streaming.spotify_Embed+"?utm_source=generator"} width="100%" height="300" frameBorder="0" allowFullScreen="" allow="autoplay; clipboard-write; encrypted-media; fullscreen; picture-in-picture"></iframe>
        </div>


        <div id="dv_StreamingsContainer_Louvor">
            <CardStreaming colorBase="#57BB63" imgLink="spotify" link={props.infoDoCard.playlist[0].link}/>
            <CardStreaming colorBase="#CD201F" imgLink="youtube" link={props.infoDoCard.playlist[2].link}/>
            <CardStreaming colorBase="#FF9400" imgLink="deezer" link={props.infoDoCard.playlist[1].link}/>
        </div>


        <div id="dv_FormaçãoContainer_Louvor">
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