import React, { useState, useEffect } from "react";
import "./../styles/Search.css";
import ShoesCard from "./ShoesCard";
import { useNavigate } from "react-router-dom";
import axios from "axios";

const Search = () => {
    const nav = useNavigate();
    const [searchValue, setSearchValue] = useState("");
    const [shoes, setShoes] = useState([]);
    const [allShoes, setAllShoes] = useState([]);
    //const [isLoading, setIsLoading] = useState(false);
    const [userId, setUserId] = useState(null);


        useEffect(() => {

            const token = localStorage.getItem("token");
            if (!token) {
                nav("/signup");
            } else {
                fetchAllShoes();
            }
        }, []);

        const fetchAllShoes = async () => {
            try {
                const response = await axios.get("/api/shoe/all");
                console.log("API Response", response)
                setShoes(response.data);
                setAllShoes(response.data);
            } catch (error) {
                console.log("Failed to fetch all shoes", error);
            }
        }

    const handleSearch = async () => {
        try {
            if (searchValue) {
                const response = await axios.get(`/api/shoe/search/${searchValue}`);
                console.log(shoes)
                setShoes(response.data);
            } else {
                setShoes(allShoes);
                console.log(shoes);
            }
        } catch (error) {
            console.log("Search failed", error);
        }
    }

    const handleSearchInputChange = async (e) => {
        setSearchValue(e.target.value);
        //handleSearch();
    }

    const handleKeyPress = (e) => {
        if (e.key === "Enter") {
            handleSearch();
        }
    };


    //if (isLoading) {
    //    return (
    //        <p>is Loading...</p>
    //    )
    //}

    return (
        <section className="SearchContainer">
            <p className="SearchTitle">LOOK FOR THE SHOE</p>
            <p className="SearchTitle">THAT FITS YOUR</p>
            <p className="SearchTitle">STYLE</p>
            <input className="SearchInput" type="search" placeholder="SEARCH" value={searchValue} onChange={handleSearchInputChange} onKeyDown={handleKeyPress} />
            <ShoesCard shoes={shoes} userId={ userId } />
        </section>
    )
}

export default Search;