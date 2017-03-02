var webpack = require("webpack");
var path = require("path");
var ForkCheckerPlugin = require('awesome-typescript-loader').ForkCheckerPlugin;
//var CopyWebpackPlugin = require('copy-webpack-plugin');
var CleanWebpackPlugin = require('clean-webpack-plugin');
//var ExtractTextPlugin = require('extract-text-webpack-plugin');

var srcRoot = 'ClientApplication/src';
var distRoot = 'wwwroot/app';

console.log('@@@@@@@@@@@@@@@ START WEBPACK BUILD - DEVELOPMENT @@@@@@@@@@@@@@@');

module.exports = {
    cache: true,
    devtool: 'source-map',
    performance: {
        hints: false
    },
    resolve: {
        extensions: ["", ".js", ".ts", ".json", ".html" /* , ".css", ".scss" */ ]
    },
    devServer: {
        historyApiFallback: true,
        stats: 'minimal',
        outputPath: path.join(__dirname, distRoot)
    },

    context: path.resolve(__dirname, srcRoot),
    entry: {
        polyfills: './polyfills.ts',
        vendor: './vendor.ts',
        main: './main.ts'
    },
    output: {
        path: path.resolve(__dirname, distRoot),
        publicPath: "/app/",
        filename: "[name].js",
        sourceMapFilename: '[name].map',
        chunkFilename: "[name].js"
    },

    module: {
        loaders: [
            {
                test: /\.ts$/,
                exclude: /\/node_modules\//,
                include: /ClientApplication/,
                loader: "awesome-typescript-loader!angular2-template-loader!angular2-load-children-loader"
            },
            {
                test: /\.(png|jpg|gif|woff|woff2|ttf|svg|eot)$/,
                loader: 'file-loader?name=assets/[name]-[hash:6].[ext]'
            },
            {
                test: /favicon.ico$/,
                loader: 'file-loader?name=/[name].[ext]'
            },
            {
                test: /\.html$/,
                loader: 'raw-loader'
            },
            //{
            //    test: /\.css$/,
            //    include: /ClientApplication/,
            //    loader: 'style-loader!css-loader'
            //},
            //{
            //    test: /\.scss$/,
            //    include: /ClientApplication/,
            //    loader: ExtractTextPlugin.extract('css!sass')
            //}
        ],
        noParse: [
          /\/node_modules\/[^!]+$/
        ]
    },

    plugins: [

        new webpack.NoErrorsPlugin(),

        new webpack.optimize.CommonsChunkPlugin({ name: ['polyfills', 'vendor', 'main'].reverse(), minChunks: Infinity }),

        new CleanWebpackPlugin([
            path.resolve(__dirname, distRoot)
        ]),

        new ForkCheckerPlugin(),

        //new ExtractTextPlugin('../assets/css/[name].css', {
        //    allChunks: true
        //})
    ]

    //watch: true,
    //watchOptions: {
    //    aggregateTimeout: 300 // 300 default
    //}
};