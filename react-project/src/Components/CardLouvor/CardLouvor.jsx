import './CardLouvor.css';
import CardFuncao from '../CardFuncao/CardFuncao';
import CardStreaming from '../CardStreaming/CardStreaming';
import CardsHeaders from '../CardsHeader/CardsHeader';
import ItemPlaylist from '../ItemPlaylist/ItemPlaylist';

export default function CardLouvor(props) {

  let dateService = new Date(props.infoDoCard.servico.data).getDay()
  console.log(props.infoDoCard)
  return (
    <div className="dv_Container"
    style = {dateService === 5 ? {backgroundColor: 'rgba(190, 208, 21, 0.1)'} : {backgroundColor: 'rgba(255, 255, 255, 0.4)'} }
      >

      <CardsHeaders
        infoDoServico={props.infoDoCard.servico}
      />

      <div className='dv_PlaylistContainer'>

        {props.infoDoCard.playlists_Info?.map((playlist, i) => (
            <ItemPlaylist
            coverMusic={playlist.musica.coverLink}
            musicTitle={playlist.musica.titulo}
            artistName={playlist.musica.artista}
            musicTone={playlist.tom}
            vslink={playlist.vsLink}
            cifralink={playlist.crifraLink}
            vozeslink={playlist.vozesLink}
            letralink={playlist.letraLink}
            background={playlist.musica.colorBase + "66"}
            key={i}
          />
        ))}

      </div>

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