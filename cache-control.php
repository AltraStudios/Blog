<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use ResponseCache;
use Illuminate\Support\Facades\Redirect;

/**
 * Post Controller is Used to handle post show/create/update operations
 */
class PostController extends Controller
{
    public $IndexStaticCacheHeader = "max-age=604800"; // 7 Day

    /**
     * Show Single Article by URL
     * 
     * @param string $url Unique URL to article
     */
    public function index($id)
    {
        // Load Post Data from DB
        
        // Return the post result view
        return  response()
            ->view('Posts.index', ['model' => $data])
            ->header('Cache-Control', $this->IndexStaticCacheHeader);
    }
}
