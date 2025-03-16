import React from 'react';
import { NavLink, useLocation } from "react-router-dom";
export const HeaderMiddle = () => {
    const location = useLocation();
    const isRouteActive = (path) => location.pathname === path;
    return (
        <div className="container">
            <div className="row">
                <div className="col-lg-3">
                    <div className="header__logo">
                        <a href="./index.html"><img src='/img/logo.png' alt="" /></a>
                    </div>
                </div>
                <div className="col-lg-6">
                    <nav className="header__menu">
                        <ul>
                            <li className={ (isRouteActive("/")  ? "active" : "")}><NavLink to="/">Home</NavLink></li>
                            <li className={ (isRouteActive("/shop") ? "active" : "")}><NavLink to="/shop">Shop</NavLink></li>
                            <li><a href="#">Pages</a>
                                <ul className="header__menu__dropdown">
                                    <li className={(isRouteActive("shop-details")? "active" : "")}><NavLink to="shop-details">Shop details</NavLink></li>
                                    <li className={(isRouteActive("shopping-cart") ? "active" : "")}><NavLink to="shopping-cart">Shoping Cart</NavLink></li>
                                    <li><a href="./checkout.html">Check Out</a></li>
                                    <li><a href="./blog-details.html">Blog Details</a></li>
                                </ul>
                            </li>
                            <li><a href="./blog.html">Blog</a></li>
                            <li><a href="./contact.html">Contact</a></li>
                        </ul>
                    </nav>
                </div>
                <div className="col-lg-3">
                    <div className="header__cart">
                        <ul>
                            <li><a href="#"><i className="fa fa-heart"></i> <span>1</span></a></li>
                            <li><a href="#"><i className="fa fa-shopping-bag"></i> <span>3</span></a></li>
                        </ul>
                        <div className="header__cart__price">item: <span>$150.00</span></div>
                    </div>
                </div>
            </div>
            <div className="humberger__open">
                <i className="fa fa-bars"></i>
            </div>
        </div>
    )
}
