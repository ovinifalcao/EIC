import './CardLouvor.css';
import CardFuncao from '../CardFuncao/CardFuncao';
import CardStreaming from '../CardStreaming/CardStreaming';
import CardsHeaders from '../CardsHeader/CardsHeader';
import ItemPlaylist from '../ItemPlaylist/ItemPlaylist';

export default function CardLouvor(props) {
<<<<<<< HEAD
=======

  let dateService = new Date(props.infoDoCard.servico.data).getDay()
  console.log(dateService)

    return (
      <div className="dv_Container"
      style = {dateService === 5 ? {backgroundColor: 'rgba(190, 208, 21, 0.1)'} : {backgroundColor: 'rgba(255, 255, 255, 0.4)'} }
      >
>>>>>>> 74bbf4e (Adding diff color for friday Schedules)


  const menuNames = {
    first: "first",
    second: "second",
    third: "third",
    fourth: "fourth",
    fiveth: "fiveth"
  }

  return (
    <div className="dv_Container">

      <CardsHeaders
        infoDoServico={props.infoDoCard.servico}
      />

      <div className='dv_PlaylistContainer'>

        <ItemPlaylist
          coverMusic="https://upload.wikimedia.org/wikipedia/pt/c/ca/Entre_-_Paulo_C%C3%A9sar_Baruk.jpg"
          musicTitle="Dependo de Ti"
          artistName="Baruk"
          musicTone="Eb"
          vslink=""
          cifralink=""
          vozeslink=""
          letralink=""
          background="#22577E"
          index={0}
      />

        <ItemPlaylist
          coverMusic="https://upload.wikimedia.org/wikipedia/pt/c/ca/Entre_-_Paulo_C%C3%A9sar_Baruk.jpg"
          musicTitle="Eu navegarei"
          artistName="Kemuel"
          musicTone="Eb"
          vslink=""
          cifralink=""
          vozeslink=""
          letralink=""
          background="#5584AC"
          index={1}
        />

        <ItemPlaylist
          coverMusic="https://upload.wikimedia.org/wikipedia/pt/c/ca/Entre_-_Paulo_C%C3%A9sar_Baruk.jpg"
          musicTitle="Emaus"
          artistName="Morada"
          musicTone="Eb"
          vslink=""
          cifralink=""
          vozeslink=""
          letralink=""
          background="#95D1CC"
          index={2}
      />

        <ItemPlaylist
          coverMusic="https://upload.wikimedia.org/wikipedia/pt/c/ca/Entre_-_Paulo_C%C3%A9sar_Baruk.jpg"
          musicTitle="Canção de Milena"
          artistName="ICF Capão"
          musicTone="Eb"
          vslink=""
          cifralink=""
          vozeslink=""
          letralink=""
          background="#6E85B2"
          index={3}
        />

      </div>

      {/* <div id="dv_SpotifyEmbedded_Louvor">
            <iframe src={"https://open.spotify.com/embed/playlist/"+props.infoDoCard.playlist[0].streaming.spotify_Embed+"?utm_source=generator"} width="100%" height="300" frameBorder="0" allowFullScreen="" allow="autoplay; clipboard-write; encrypted-media; fullscreen; picture-in-picture"></iframe>
        </div> */}


      {/* <div id="dv_StreamingsContainer_Louvor">
            <CardStreaming colorBase="#57BB63" imgLink="spotify" link={props.infoDoCard.playlist[0].link}/>
            <CardStreaming colorBase="#CD201F" imgLink="youtube" link={props.infoDoCard.playlist[2].link}/>
            <CardStreaming colorBase="#FF9400" imgLink="deezer" link={props.infoDoCard.playlist[1].link}/>
        </div> */}


      <div id="dv_FormaçãoContainer_Louvor">
        {props.infoDoCard.formacao?.map((formacao, i) => (
          <CardFuncao
            infoFunca={formacao}
            key={i}
          />
        ))}
      </div>

    </div>
  );
}