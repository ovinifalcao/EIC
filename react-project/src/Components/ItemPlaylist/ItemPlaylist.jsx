import React, { useEffect, useRef } from "react";
import './ItemPlaylist.css';


const ItemPlaylist = (props) => {

    let expandRef = useRef();
    let itemRef = useRef();
    let arrowRef = useRef();

    useEffect(() => {
        expandRef.current.addEventListener('click', () => {
            itemRef.current.classList.toggle('open');
            arrowRef.current.classList.toggle('open');
            // arrowRef.current.style.transform = 'rotate(180deg)'
        })
    });

    return (
        <div className='dv_ItemPlaylist open' ref={itemRef} style={{ background: props.background }}>
            <div className="dv_ItemContent">
                <img className='img_coverMusic' src={props.coverMusic} alt="" />

                <div className='dv_musicInfos'>
                    <p className='p_musicTitle'>{props.musicTitle}</p>
                    <p className='p_artistName'>{props.artistName}</p>
                </div>

                <div className='dv_flexEndItems' ref={expandRef}>
                    <p className="p_tone">Tom</p>
                    <p className='p_musicTone'>{props.musicTone}</p>
                    <svg ref={arrowRef} className='svg_openSection' xmlns="http://www.w3.org/2000/svg" width={15} viewBox="0 0 8.11 4.78"><path d="M299.75,302.06,295.69,298l.73-.73,3.33,3.35,3.33-3.33.73.73Z" transform="translate(-295.69 -297.27)" /></svg>
                </div>
            </div>

            <div className="dv_internalItems">
                <div className="dv_internalItem">
                    <p className="p_internalTitle">VS</p>
                    <svg width={20} xmlns="http://www.w3.org/2000/svg" fill="#fff" viewBox="0 0 19.66 28.09"><path d="M31.72,38H16.28a2.08,2.08,0,0,1-2.11-2.1V12.06A2.08,2.08,0,0,1,16.28,10H31.72a2.08,2.08,0,0,1,2.11,2.1V35.94A2.08,2.08,0,0,1,31.72,38Zm0-2.1V12.06H16.28V35.94ZM24,19.65A2.65,2.65,0,0,0,26.7,17a2.67,2.67,0,1,0-5.33,0,2.53,2.53,0,0,0,.77,1.89A2.56,2.56,0,0,0,24,19.65ZM24,34a5.7,5.7,0,0,0,5.76-5.76A5.69,5.69,0,0,0,24,22.46a5.69,5.69,0,0,0-5.76,5.75A5.7,5.7,0,0,0,24,34Zm0-2.11a3.48,3.48,0,0,1-2.58-1.07,3.65,3.65,0,1,1,6.23-2.58,3.52,3.52,0,0,1-1.07,2.58A3.48,3.48,0,0,1,24,31.86Zm-7.72-19.8v0Z" transform="translate(-14.17 -9.96)" /></svg>
                </div>
                <div className="dv_internalItem">
                    <p className="p_internalTitle">Cifra</p>
                    {/* <svg width={25} xmlns="http://www.w3.org/2000/svg" fill="#fff" viewBox="0 0 38 28"><path d="M31.49,38a5.89,5.89,0,0,1-4.2-1.67,5.43,5.43,0,0,1-1.75-4.08,5.72,5.72,0,0,1,5.75-5.75,8.37,8.37,0,0,1,1.58.15,6.76,6.76,0,0,1,1.52.5V10h9.1v3.55h-6.1V32.3a5.42,5.42,0,0,1-1.72,4A5.81,5.81,0,0,1,31.49,38Zm-26-8.5v-3h15.3v3Zm0-8.25v-3H29.14v3Zm0-8.25V10H29.14v3Z" transform="translate(-5.49 -10)" /></svg></div> */}
                    <svg width={30} xmlns="http://www.w3.org/2000/svg" viewBox="0 0 32.38 37.84"><path fill="#fff" d="M29.48,36.68a4.39,4.39,0,0,1-3.13-1.25,4.07,4.07,0,0,1-1.31-3,4.27,4.27,0,0,1,4.3-4.3,5.74,5.74,0,0,1,1.17.12,4.75,4.75,0,0,1,1.14.37V15.78h6.79v2.65H33.89v14a4.06,4.06,0,0,1-1.29,3A4.33,4.33,0,0,1,29.48,36.68Zm-19.4-6.35V28.09H21.5v2.24Zm0-6.15V21.94H27.73v2.24Zm0-6.16V15.78H27.73V18Z" transform="translate(-8.04 -4.47)" /><rect fill="transparent" width="32.38" height="37.84" /></svg>
                </div>
                <div className="dv_internalItem">
                    <p className="p_internalTitle">Vozes</p>
                    <svg width={30} xmlns="http://www.w3.org/2000/svg" viewBox="0 0 32.38 37.84"><rect fill="transparent" width="32.38" height="37.84"/><path fill="#fff" d="M24,27.13a3.8,3.8,0,0,1-2.87-1.21A4.05,4.05,0,0,1,20,23V15.12a4,4,0,0,1,6.9-2.86A3.91,3.91,0,0,1,28,15.12V23a4.05,4.05,0,0,1-1.17,2.92A3.8,3.8,0,0,1,24,27.13Zm-1.29,9.79V32.59A9.57,9.57,0,0,1,14.18,23H16.8a6.78,6.78,0,0,0,2.11,5,7.29,7.29,0,0,0,10.18,0,6.78,6.78,0,0,0,2.11-5h2.62a9.57,9.57,0,0,1-8.53,9.59v4.33Z" transform="translate(-7.81 -5.08)"/></svg>
                </div>

                <div className="dv_internalItem">
                    <p className="p_internalTitle">Letra</p>
                    <svg width={30} xmlns="http://www.w3.org/2000/svg" viewBox="0 0 32.38 37.84"><rect fill="transparent" width="32.38" height="37.84"/><path fill="#fff" d="M15.54,32.37H27v-2.5H15.54Zm0-7.12H32.46v-2.5H15.54Zm0-7.12H32.46v-2.5H15.54ZM11.5,39A2.56,2.56,0,0,1,9,36.5v-25A2.56,2.56,0,0,1,11.5,9h25A2.56,2.56,0,0,1,39,11.5v25A2.56,2.56,0,0,1,36.5,39Zm0-2.5h25v-25h-25Zm0-25v0Z" transform="translate(-7.81 -5.08)"/></svg>
                </div>
            </div>
        </div >
    )
}

export default ItemPlaylist;