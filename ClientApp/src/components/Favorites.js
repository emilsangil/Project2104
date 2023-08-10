import React, { useState, useEffect } from "react";
import "./../styles/Favorites.css";
import ShoesCard from "./ShoesCard";
import axios from "axios";
import { useNavigate } from "react-router-dom";

const Favorites = () => {
    const nav = useNavigate();
    const [favoriteShoes, setFavoriteShoes] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [userId, setUserId] = useState(localStorage.getItem("userLoggedIn"));

    useEffect(() => {

        const token = localStorage.getItem("token");
        const loggedInUser = localStorage.getItem("userLoggedIn");
        if (!token) {
            nav("/signup");
        } else {
            fetchFavorites(loggedInUser);
            setIsLoading(false);
        }

    }, [favoriteShoes]);

    const fetchFavorites = async (user) => {
        await axios.get(`/api/user/${user}/favorites`)
            .then(response => {
                setFavoriteShoes(response.data);
            })
            .catch(error => {
                console.error("Failed to fetch favorite shoes", error);
            });
        
    }

    if (isLoading) {
        return (
            <p>is Loading...</p>
        )
    }
    return (
        <article className="FavoritesContainer">
            <p>FAVORITES</p>
            <ShoesCard isFavorites={true} shoes={favoriteShoes} userId={ userId } />
        </article>
    )
}

export default Favorites;