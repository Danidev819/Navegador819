
namespace cocos4d {
  

  void protectSSLAttack();
  
}

class CCDirector {
  
  
  protected:
  
  virtual void privateDirector();
  
  virtual bool createDirector();
  
  public:
  
  void initSelf();
  
  void sharedDirector();
  
  
}




class CCLayer : public CCDirector{

  
  protected:
  
  virtual bool enableHook();
  
  virtual void createHook();
  
  virtual bool initSelf();
  
  
  public:
  
  void sharedLayer();
  
  void sharedStatus();
  
}

  class CCMenu : public CCDirector {
    
    
    protected:
    
    
   virtual void hookProccess();
    
    
    public:
    
    void sharedMenu();


    inline bool (__thiscall* init)(CCLayer* self);
    
    
    
  }
