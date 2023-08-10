import React from "react";
import { useNavigate } from "react-router-dom";
import "./../styles/ShoeCard.css";
import axios from "axios";

const ShoeCard = ({ isFavorites, shoe, userId }) => {
    const nav = useNavigate();

    const handleLearnMore = () => {
        nav(`/shoedetails/${shoe.id}`, { state: { shoe } });
        console.log("Learn more")
    }

    const handleRemoveToFavorites = async () => {
        console.log(shoe.id);
        console.log(userId);
        try {
            const response = await axios.delete(`/api/user/${userId}/favorites/${shoe.id}`);
            console.log("Shoe removed", response.data);
        } catch (error) {
            console.log("Error removing shoe", error);
        }
    }

    return (
        <article className="ShoeContainer">
            <article className="ShoeNameContainer">
                <p>{ shoe.name }</p>
            </article>
            <article className="ShoeImageContainer">
                <img src={ shoe.image } />
            </article>
            <article className="ShoeDetailsContainer">
                <p></p>
                <article className={isFavorites ? "ShowDetailsButtonFavorite" : "ShoeDetailsButtonContainer"}>
                    <input type="button" value="LEARN MORE" onClick={ handleLearnMore } />
                    {isFavorites ? <input type="button" value="REMOVE" id="OrangeButton" onClick={ handleRemoveToFavorites } /> : null}
                </article>
            </article>
        </article>
    )
}

export default ShoeCard;