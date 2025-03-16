import React from 'react';
import Slider from 'react-slick';
import 'slick-carousel/slick/slick-theme.css';
import 'slick-carousel/slick/slick.css';
import './SliderComponent.css';

const NextArrow = ({ onClick }) => {
    return (
        <div className="custom-arrow custom-next" onClick={onClick}>
            <span>{">"}</span>
        </div>
    );
};

const PrevArrow = ({ onClick }) => {
    return (
        <div className="custom-arrow custom-prev" onClick={onClick}>
            <span>{"<"}</span>
        </div>
    );
};

export const SliderComponent = (props) => {
    const settings = {
        dots: false,
        infinite: true,
        speed: 500,
        slidesToShow: props.slidesToShow, // Adjust based on the number of items to display
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 3000,
        nextArrow: <NextArrow />,
        prevArrow: <PrevArrow  />,
        arrows: props.showArrows
    };
    const products = props.products;
    const renderItem = props.renderItem;
    return (<div >
        <Slider {...settings}>
            {products.map((product) => (
               renderItem(product)
            ))}
        </Slider>
    </div>)
}