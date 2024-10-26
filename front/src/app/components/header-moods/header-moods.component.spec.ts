import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeaderMoodsComponent } from './header-moods.component';

describe('HeaderMoodsComponent', () => {
  let component: HeaderMoodsComponent;
  let fixture: ComponentFixture<HeaderMoodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HeaderMoodsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HeaderMoodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
