import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import "./../styles/ShoeDetail.css";
import { useLocation } from "react-router-dom";
import axios from "axios";

const ShoeDetails = () => {
    const nav = useNavigate();
    const location = useLocation();
    const shoe = location.state.shoe;
    const [userId, setUserId] = useState(null);
    const [specificShoe, setSpecificShoe] = useState({});
    const [isFavorite, setIsFavorite] = useState(false);


    useEffect(() => {
        const token = localStorage.getItem("token");
        const loggedInUser = localStorage.getItem("userLoggedIn")
        setUserId(loggedInUser)
        console.log(token)
        console.log(loggedInUser)

        if (!token) {
            nav("/signup")
        } 
    }, []);

    useEffect(() => {
        const fetchFavorites = async () => {
            try {
                const response = await axios.get(`/api/user/${userId}/favorites`);
                const favorite = response.data;
                setIsFavorite(favorite.some(favShoe => favShoe.id === shoe.id));
            } catch (error) {
                console.log("Failed to fetch favorites", error);
            }
        };

        if (userId) {
            fetchFavorites();
        }
    }, [userId, shoe.id, isFavorite]);


    const handleBack = () => {
        nav(-1);
    };


    const handleAddToFavorites = async () => {
        try {
            if (isFavorite) {
                const response = await axios.delete(`/api/user/${userId}/favorites/${shoe.id}`);
                if (response.status === 200) {
                    setIsFavorite(false);
                }
                console.log("Shoe removed from favorites", response.data);
            } else {
                const response = await axios.post(`/api/user/${userId}/favorites`, shoe);
                if (response.status === 200) {
                    setIsFavorite(true);
                }
                console.log("Shoe added to favorites", response.data);
            }
        } catch (error) {
            console.log("Failed to update favorites", error);
        }
    };

    return (
        <article className="ShoeDetailsContainer">
            <article className="ShoeDetailsNameContainer">
                <p>{ shoe.name }</p>
            </article>
            <article className="ShoeDetailsImageContainer">
                <img src={ shoe.image } />
            </article>
            <article className="ShoeDetailsInfoContainer">
                <p>{ shoe.description }</p>
                <p>Retails Price: ${ shoe.price }</p>
            </article>
            <article className="ShoeDetailsButtonContainer">
                {isFavorite ? (
                    <input type="button" value="REMOVE" onClick={handleAddToFavorites} />
                ) : (
                    <input type="button" value="FAVORITE" onClick={handleAddToFavorites} />
                )}
                <input type="button" value="BACK" onClick={ handleBack } />
            </article>
        </article>
    )
}

export default ShoeDetails;