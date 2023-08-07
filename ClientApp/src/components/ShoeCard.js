import React from "react";
import "./../styles/ShoeCard.css";

const ShoeCard = ({ isFavorites }) => {

    return (
        <article className="ShoeContainer">
            <article className="ShoeNameContainer">
                <p>NIKE</p>
                <p>AIR</p>
                <p>FORCE</p>
            </article>
            <article className="ShoeImageContainer">
                <img src="/images/testshoes.png"/>
            </article>
            <article className="ShoeDetailsContainer">
                <p></p>
                <article className={isFavorites ? "ShowDetailsButtonFavorite" : "ShoeDetailsButtonContainer"}>
                    <input type="button" value="LEARN MORE" />
                    {isFavorites ? <input type="button" value="REMOVE" id="OrangeButton" /> : null}
                </article>
            </article>
        </article>
    )
}

export default ShoeCard;