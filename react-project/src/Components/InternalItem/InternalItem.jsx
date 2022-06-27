import React from "react";
import './InternalItem.css'

const InternalItem = (props) => {

    return (
        <a href={props.link}>
            <div className="dv_internalItem">
                <p className="p_internalTitle">{props.itemTitle}</p>
                {props.icon}
            </div>
        </a>
    )

}

export default InternalItem;