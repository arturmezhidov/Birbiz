var path = require('path');
var webpack = require('webpack');

var HtmlWebpackPlugin = require('html-webpack-plugin');
var CopyWebpackPlugin = require('copy-webpack-plugin');
var CleanWebpackPlugin = require('clean-webpack-plugin');

console.log("@@@@@@@@@@@@@@@ USING PRODUCTION @@@@@@@@@@@@@@@");

module.exports = {

    //#region entry
    entry: {
        polyfills: './ClientApplication/src/polyfills.ts',
        vendor: './ClientApplication/src/vendor.ts',
        main: './ClientApplication/src/main-aot.ts' // AoT compilation
    },
    //#endregion

    //#region output
    output: {
        path: "./wwwroot/",
        filename: 'dist/[name].[hash].bundle.js',
        publicPath: "/",
        chunkFilename: '[id].chunk.js'
    },
    //#endregion

    //#region resolve
    resolve: {
        extensions: ['.ts', '.js', '.json', '.css', '.scss', '.html']
    },
    //#endregion

    //#region devServer
    devServer: {
        historyApiFallback: true,
        stats: 'minimal',
        outputPath: path.join(__dirname, 'wwwroot/')
    },
    //#endregion

    //#region module
    module: {
        rules: [
            {
                test: /\.ts$/,
                loaders: [
                    'awesome-typescript-loader'
                ]
            },
            {
                test: /\.(png|jpg|gif|woff|woff2|ttf|svg|eot)$/,
                loader: "file-loader?name=assets/[name]-[hash:6].[ext]",
            },
            {
                test: /favicon.ico$/,
                loader: "file-loader?name=/[name].[ext]",
            },
            {
                test: /\.css$/,
                loader: "style-loader!css-loader"
            },
            {
                test: /\.scss$/,
                exclude: /node_modules/,
                loaders: ["style-loader", "css-loader", "sass-loader"]
            },
            {
                test: /\.html$/,
                loader: 'raw-loader'
            }
        ],
        exprContextCritical: false
    },
    //#endregion

    //#region plugins
    plugins: [
        new CleanWebpackPlugin(
            [
                './wwwroot/dist',
                './wwwroot/assets'
            ]
        ),
        new webpack.NoErrorsPlugin(),
        new webpack.optimize.UglifyJsPlugin({
            compress: {
                warnings: false
            },
            output: {
                comments: false
            },
            sourceMap: false
        }),
        new webpack.optimize.CommonsChunkPlugin(
            {
                name: ['vendor', 'polyfills']
            }),

        new HtmlWebpackPlugin({
            filename: 'index.html',
            inject: 'body',
            template: 'ClientApplication/src/index.html'
        }),

        new CopyWebpackPlugin([
            { from: './ClientApplication/src/assets/*.*', to: "assets/", flatten: true }
        ])
    ]
    //#endregion
};