import React from "react";
import "./../styles/ShoeDetail.css";

const ShoeDetails = () => {
    return (
        <article className="ShoeDetailsContainer">
            <article className="ShoeDetailsNameContainer">
                <p>NIKE</p>
                <p>AIR FORCE 1 07</p>
            </article>
            <article className="ShoeDetailsImageContainer">
                <img src="/images/testshoes-lg.png"/>
            </article>
            <article className="ShoeDetailsInfoContainer">
                <p>The radiance lives on in the Nike Air Force 1 ’07, the b-ball OG that puts a fresh spin on what you know best: durably stitched overlays, clean finishes and the perfect amount of flash to make you shine.</p>
                <p>Retails Price: $145</p>
            </article>
            <article className="ShoeDetailsButtonContainer">
                <input type="button" value="FAVORITE" />
                <input type="button" value="BACK" />
            </article>
        </article>
    )
}

export default ShoeDetails;