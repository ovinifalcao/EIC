import './CardStreaming.css';

export default function CardStreaming(props) {
    return (
      <div id="dv_Container_Streaming" style={{backgroundColor:props.colorBase}}>
          <a href={props.link} target="_blank">
            <img id="img_logo_streaming"  src={"https://equipeicfcapao.com.br/imgs/"+props.imgLink+".png"}/>
          </a>
      </div>
    );
  }